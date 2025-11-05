import tkinter as tk
from tkinter import ttk, messagebox
from datetime import datetime, timedelta

class HolidayApp(tk.Tk):
    
    def __init__(self):
        super().__init__()
        self.title("laba-7-n-1")
        self.geometry("480x350")
        self.resizable(False, False)
        
        self.setup_ui()

    def setup_ui(self):
        input_frame = ttk.LabelFrame(self, text="Enter the public holiday date", padding="15")
        input_frame.pack(padx=15, pady=15, fill="x")

        ttk.Label(input_frame, text="Day (e.g., 28):").grid(row=0, column=0, padx=5, pady=10, sticky="w")
        self.entry_day = ttk.Entry(input_frame, width=15)
        self.entry_day.grid(row=0, column=1, padx=5, pady=10)

        ttk.Label(input_frame, text="Month (e.g., 6):").grid(row=1, column=0, padx=5, pady=10, sticky="w")
        self.entry_month = ttk.Entry(input_frame, width=15)
        self.entry_month.grid(row=1, column=1, padx=5, pady=10)

        self.check_button = ttk.Button(self, text="Check Date", command=self.check_holiday_date)
        self.check_button.pack(pady=5)

        output_frame = ttk.LabelFrame(self, text="Check Result", padding="15")
        output_frame.pack(padx=15, pady=10, fill="both", expand=True)

        self.output_text = tk.Text(output_frame, height=8, width=50, font=("Consolas", 10), wrap="word")
        self.output_text.pack(fill="both", expand=True)
        self.output_text.config(state="disabled")

    def check_holiday_date(self):
        try:
            day = int(self.entry_day.get())
            month = int(self.entry_month.get())

            current_year = datetime.now().year

            holiday_date = datetime(current_year, month, day)

            day_of_week_num = holiday_date.isoweekday()
            date_str = holiday_date.strftime("%d.%m.%Y")

            output = f"Holiday Date: {date_str}\n"
            output += f"Day of Week Number (1=Mon, 7=Sun): {day_of_week_num}\n"
            output += "----------------------------------------\n"

            if day_of_week_num == 7:
                output += "❗️ The holiday falls on a Sunday.\n"
                
                next_monday = holiday_date + timedelta(days=1)
                next_monday_str = next_monday.strftime("%d.%m.%Y")
                
                output += f"Day off is moved to: {next_monday_str}"
            else:
                output += "✅ No transfer needed."
            
            self.output_text.config(state="normal")
            self.output_text.delete("1.0", "end")
            self.output_text.insert("end", output)
            self.output_text.config(state="disabled")

        except ValueError:
            messagebox.showerror("Input Error", 
                                 "Invalid date!\n\n"
                                 "Please enter valid numbers (e.g., Day: 24, Month: 8).")
        except Exception as e:
            messagebox.showerror("Unexpected Error", f"An error occurred: {e}")

if __name__ == "__main__":
    app = HolidayApp()
    app.mainloop()