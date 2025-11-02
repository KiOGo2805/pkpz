import tkinter as tk
from tkinter import ttk, messagebox
from datetime import datetime, timedelta

# ----------------------------------------------------
# 1. MAIN APPLICATION CLASS
# ----------------------------------------------------
class HolidayApp(tk.Tk):
    
    def __init__(self):
        super().__init__()
        self.title("Holiday Transfer Planner")
        self.geometry("480x350")
        self.resizable(False, False)
        
        # Create all UI elements
        self.setup_ui()

    def setup_ui(self):
        # --- Input Frame ---
        input_frame = ttk.LabelFrame(self, text="Enter the public holiday date", padding="15")
        input_frame.pack(padx=15, pady=15, fill="x")

        ttk.Label(input_frame, text="Day (e.g., 28):").grid(row=0, column=0, padx=5, pady=10, sticky="w")
        self.entry_day = ttk.Entry(input_frame, width=15)
        self.entry_day.grid(row=0, column=1, padx=5, pady=10)

        ttk.Label(input_frame, text="Month (e.g., 6):").grid(row=1, column=0, padx=5, pady=10, sticky="w")
        self.entry_month = ttk.Entry(input_frame, width=15)
        self.entry_month.grid(row=1, column=1, padx=5, pady=10)

        # --- Button ---
        self.check_button = ttk.Button(self, text="Check Date", command=self.check_holiday_date)
        self.check_button.pack(pady=5)

        # --- Output Frame ---
        output_frame = ttk.LabelFrame(self, text="Check Result", padding="15")
        output_frame.pack(padx=15, pady=10, fill="both", expand=True)

        self.output_text = tk.Text(output_frame, height=8, width=50, font=("Consolas", 10), wrap="word")
        self.output_text.pack(fill="both", expand=True)
        self.output_text.config(state="disabled") # Make it read-only

    # ----------------------------------------------------
    # 2. CORE LOGIC
    # ----------------------------------------------------
    def check_holiday_date(self):
        try:
            # --- 1. Get data from input fields ---
            day = int(self.entry_day.get())
            month = int(self.entry_month.get())

            # --- 2. Determine the current year ---
            # Requirement: "...this year"
            current_year = datetime.now().year

            # --- 3. Create datetime object ---
            holiday_date = datetime(current_year, month, day)

            # --- 4. Determine day of the week (Requirement 4) ---
            # .isoweekday() returns: Monday=1, Tuesday=2, ... Sunday=7
            # This matches the "1 — Monday" condition
            day_of_week_num = holiday_date.isoweekday()
            date_str = holiday_date.strftime("%d.%m.%Y")

            # --- 5. Prepare output ---
            output = f"Holiday Date: {date_str}\n"
            output += f"Day of Week Number (1=Mon, 7=Sun): {day_of_week_num}\n"
            output += "----------------------------------------\n"

            # --- 6. Check for Sunday (Requirement 5) ---
            if day_of_week_num == 7: # 7 = Sunday in ISO
                # Holiday is on a Sunday
                output += "❗️ The holiday falls on a Sunday.\n"
                
                # Calculate the next Monday
                next_monday = holiday_date + timedelta(days=1)
                next_monday_str = next_monday.strftime("%d.%m.%Y")
                
                output += f"Day off is moved to: {next_monday_str}"
            else:
                # Holiday is not on a Sunday
                output += "✅ No transfer needed."
            
            # --- 7. Display the result ---
            self.output_text.config(state="normal") # Allow editing
            self.output_text.delete("1.0", "end")
            self.output_text.insert("end", output)
            self.output_text.config(state="disabled") # Disable editing again

        except ValueError:
            # Will trigger if input is not a number or is an invalid date (e.g., 31.04)
            messagebox.showerror("Input Error", 
                                 "Invalid date!\n\n"
                                 "Please enter valid numbers (e.g., Day: 24, Month: 8).")
        except Exception as e:
            # Catch all other possible errors
            messagebox.showerror("Unexpected Error", f"An error occurred: {e}")

# ----------------------------------------------------
# 3. PROGRAM ENTRY POINT
# ----------------------------------------------------
if __name__ == "__main__":
    app = HolidayApp()
    app.mainloop()