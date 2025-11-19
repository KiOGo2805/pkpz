import tkinter as tk
from tkinter import ttk, messagebox
import random

FILE_L1_STUDENTS = "L1_students.txt"
FILE_L2_TICKETS = "L2_tickets.txt"
FILE_L3_RESULTS = "L3_results.txt"

def process_circular_lists(students, tickets):
    available_students = list(students)
    available_tickets = list(tickets)
    pairings = [] 

    if not available_students or not available_tickets:
        raise ValueError("Lists cannot be empty.")

    k = random.randint(1, len(available_students))
    n = random.randint(1, len(available_tickets))
    
    k_index = k - 1
    n_index = n - 1

    num_draws = min(len(available_students), len(available_tickets))

    for _ in range(num_draws):
        student_idx = k_index % len(available_students)
        ticket_idx = n_index % len(available_tickets)

        student = available_students.pop(student_idx)
        ticket = available_tickets.pop(ticket_idx)

        pairings.append(f"{student} -> {ticket}")

    return pairings

class CircularListApp(tk.Tk):
    def __init__(self):
        super().__init__()
        self.title("laba_9_n_2")
        self.geometry("600x450")
        self.resizable(False, False)
        
        self.modified_results = None

        self.setup_ui()

    def setup_ui(self):
        main_frame = ttk.Frame(self)
        main_frame.pack(fill="x", padx=10, pady=10)

        ttk.Label(main_frame, text="List L1 (Students, space-separated):", font=("Segoe UI", 9, "bold")).pack(anchor="w")
        
        self.students_var = tk.StringVar(
            value="Smith Johnson Williams Brown Davis")
        self.txt_students = ttk.Entry(main_frame, textvariable=self.students_var, font=("Consolas", 10), width=70)
        self.txt_students.pack(fill="x", padx=5, pady=5)

        ttk.Label(main_frame, text="List L2 (Tickets, space-separated):", font=("Segoe UI", 9, "bold")).pack(anchor="w", pady=(10,0))
        
        self.tickets_var = tk.StringVar(
            value="Ticket_1 Ticket_2 Ticket_3 Ticket_4 Ticket_5")
        self.txt_tickets = ttk.Entry(main_frame, textvariable=self.tickets_var, font=("Consolas", 10), width=70)
        self.txt_tickets.pack(fill="x", padx=5, pady=5)

        self.btn_process = ttk.Button(self, text="1. Save, Read from Files, and Process", 
                                      command=self.process_data)
        self.btn_process.pack(pady=10, fill="x", padx=15)

        ttk.Label(self, text="Result:", font=("Segoe UI", 9, "bold")).pack(anchor="w", padx=15)
        self.lst_result = tk.Listbox(self, height=10, font=("Consolas", 10, "bold"))
        self.lst_result.pack(pady=5, padx=15, fill="x")

        self.btn_save_result = ttk.Button(self, text="2. Save Result to File", 
                                          command=self.save_result, state="disabled")
        self.btn_save_result.pack(pady=10, fill="x", padx=15)

    def process_data(self):
        try:
            input_l1_str = self.students_var.get().strip()
            input_l2_str = self.tickets_var.get().strip()

            if not input_l1_str or not input_l2_str:
                messagebox.showerror("Empty Data", "Both lists (L1 and L2) must be filled.")
                return

            list1_from_gui = input_l1_str.split()
            list2_from_gui = input_l2_str.split()

            with open(FILE_L1_STUDENTS, "w", encoding="utf-8") as f:
                f.write("\n".join(list1_from_gui))
            with open(FILE_L2_TICKETS, "w", encoding="utf-8") as f:
                f.write("\n".join(list2_from_gui))

            with open(FILE_L1_STUDENTS, "r", encoding="utf-8") as f:
                students = f.read().splitlines()
            with open(FILE_L2_TICKETS, "r", encoding="utf-8") as f:
                tickets = f.read().splitlines()

            self.modified_results = process_circular_lists(students, tickets)

            self.display_list(self.modified_results, "Drawing Results")
            self.btn_save_result.config(state="normal")

        except Exception as e:
            messagebox.showerror(f"An error occurred", str(e))

    def save_result(self):
        if self.modified_results is None:
            messagebox.showerror("Error", "No data to save. Please process the lists first.")
            return
        
        try:
            with open(FILE_L3_RESULTS, "w", encoding="utf-8") as f:
                f.write("\n".join(self.modified_results))
            
            messagebox.showinfo("Success", f"Result successfully saved to '{FILE_L3_RESULTS}'.")

        except Exception as e:
            messagebox.showerror(f"Save Error", str(e))

    def display_list(self, data, title):
        self.lst_result.delete(0, "end")
        self.lst_result.insert("end", f"--- {title} ({len(data)} items) ---")
        if not data:
            self.lst_result.insert("end", "List is empty.")
        for item in data:
            self.lst_result.insert("end", item)


if __name__ == "__main__":
    app = CircularListApp()
    app.mainloop()