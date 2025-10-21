import tkinter as tk
from tkinter import messagebox, ttk
from abc import ABC, abstractmethod

# ----------------------------------------------------
# 1. ABSTRACT BASE CLASS: TEACHER (MODELS)
# ----------------------------------------------------
class Teacher(ABC):
    
    def __init__(self, name: str, department: str, rate: float):
        self.name = name
        self.department = department
        self.rate = rate
        self.base_salary = 15000

    @abstractmethod
    def calculate_salary(self) -> float:
        pass

    @abstractmethod
    def get_department_info(self) -> str:
        pass

    def get_common_info(self) -> str:
        return (f"Name: {self.name}\n"
                f"Department: {self.department}\n"
                f"Rate: {self.rate:.2f}")

    def is_highly_paid(self) -> bool:
        return self.calculate_salary() > 30000

# ----------------------------------------------------
# 2. DERIVED CLASS 1: PROFESSOR
# ----------------------------------------------------
class Professor(Teacher):
    
    def __init__(self, name: str, department: str, rate: float, has_doctoral: bool):
        super().__init__(name, department, rate)
        self.has_doctoral = has_doctoral
        self.prof_bonus = 0.5

    def calculate_salary(self) -> float:
        salary = self.base_salary * self.rate
        if self.has_doctoral:
             salary *= (1 + self.prof_bonus)
        return round(salary, 2)

    def get_department_info(self) -> str:
        degree = 'Doctorate' if self.has_doctoral else 'PhD'
        return f"Position: Professor. Degree: {degree}"

    def get_status(self) -> str:
        status = 'with management rights' if self.has_doctoral else 'consultant'
        return f"Status: Professor ({status})"

# ----------------------------------------------------
# 3. DERIVED CLASS 2: ASSOCIATE PROFESSOR
# ----------------------------------------------------
class AssocProf(Teacher):
    
    def __init__(self, name: str, department: str, rate: float, years_experience: int):
        super().__init__(name, department, rate)
        self.years_experience = years_experience
        self.docent_bonus_per_year = 0.01

    def calculate_salary(self) -> float:
        salary = self.base_salary * self.rate
        experience_multiplier = 1 + (self.years_experience * self.docent_bonus_per_year)
        return round(salary * experience_multiplier, 2)

    def get_department_info(self) -> str:
        return f"Position: Assoc. Professor. Experience: {self.years_experience} years."

    def check_experience_level(self) -> str:
        if self.years_experience >= 10:
            return "Experience Level: High"
        elif self.years_experience >= 5:
            return "Experience Level: Medium"
        else:
            return "Experience Level: Initial"

# ----------------------------------------------------
# 4. GUI APPLICATION CLASS
# ----------------------------------------------------
class TeacherApp(tk.Tk):
    def __init__(self):
        super().__init__()
        self.title("Lab 6: Teacher Database")
        self.geometry("950x500")
        self.resizable(False, False)
        
        self.department_list = ["Software Engineering", "Cybersecurity", "Mathematics", "Physics"]
        self.teachers_db = [] # Start with an empty database
        
        self.setup_ui()

    def setup_ui(self):
        
        # --- INPUT FRAME (Left Side) ---
        input_frame = ttk.LabelFrame(self, text="Create New Teacher", padding="10")
        input_frame.grid(row=0, column=0, padx=10, pady=10, sticky="n")

        # --- Dynamic Fields ---
        labels = ["Name:", "Rate (e.g., 1.0):", "Degree (0/1) / Experience (Years):"]
        self.input_entries = {}
        
        for i, text in enumerate(labels):
            ttk.Label(input_frame, text=text).grid(row=i, column=0, sticky="w", pady=5)
            entry = ttk.Entry(input_frame, width=30)
            entry.grid(row=i, column=1, pady=5, padx=5)
            self.input_entries[text] = entry
            
        # --- Department ComboBox ---
        ttk.Label(input_frame, text="Department:").grid(row=3, column=0, sticky="w", pady=5)
        self.input_dept = ttk.Combobox(input_frame, values=self.department_list, width=27)
        self.input_dept.set(self.department_list[0])
        self.input_dept.grid(row=3, column=1, pady=5, padx=5)
        
        # --- Position ComboBox (Switch between Professor/AssocProf) ---
        ttk.Label(input_frame, text="Position:").grid(row=4, column=0, sticky="w", pady=5)
        self.input_position = ttk.Combobox(input_frame, values=["Professor", "AssocProf"], width=27)
        self.input_position.set("Professor")
        self.input_position.grid(row=4, column=1, pady=5, padx=5)
        
        # --- Create Button ---
        ttk.Button(input_frame, text="Create Teacher", command=self.create_teacher).grid(row=5, column=0, columnspan=2, pady=10)

        # --- DATABASE FRAME (Right Side) ---
        database_frame = ttk.LabelFrame(self, text="Database Operations", padding="10")
        database_frame.grid(row=0, column=1, padx=10, pady=10, sticky="n")
        
        # Search controls
        ttk.Label(database_frame, text="Filter by Department:").pack(pady=5)
        self.search_dept = ttk.Combobox(database_frame, values=["Show All"] + self.department_list, width=25)
        self.search_dept.set("Show All")
        self.search_dept.pack(pady=5)
        
        # Buttons
        ttk.Button(database_frame, text="Show All/Filter", command=self.show_all_teachers).pack(pady=10, fill='x')
        
        # Output Text Area
        ttk.Label(database_frame, text="Results Output:").pack(pady=(10, 0))
        self.output_text = tk.Text(database_frame, height=20, width=50)
        self.output_text.pack(padx=5, pady=5)

    def get_input_values(self):
        """Safely retrieves and validates all input values."""
        
        try:
            name = self.input_entries["Name:"].get()
            rate = float(self.input_entries["Rate (e.g., 1.0):"].get())
            dept = self.input_dept.get()
            position = self.input_position.get()
            
            # --- Specific Value Parsing ---
            specific_value = self.input_entries["Degree (0/1) / Experience (Years):"].get()
            
            if position == "Professor":
                # Degree: 1 for Doctorate, 0 for PhD/no Doctorate
                specific_data = bool(int(specific_value)) 
            else: # AssocProf
                # Experience: integer years
                specific_data = int(specific_value) 

            if not name or not dept:
                 raise ValueError("Name and Department fields cannot be empty.")
            
            return name, rate, dept, position, specific_data

        except ValueError as e:
            messagebox.showerror("Input Error", f"Invalid input format: {e}.\nCheck Rate, Degree (must be 0 or 1) or Experience (must be integer).")
            return None, None, None, None, None
        
    def create_teacher(self):
        """Creates a new teacher object and adds it to the database."""
        name, rate, dept, position, specific_data = self.get_input_values()
        
        if name is None:
            return # Validation failed, error shown by get_input_values

        if position == "Professor":
            new_teacher = Professor(name, dept, rate, specific_data)
        else: # AssocProf
            new_teacher = AssocProf(name, dept, rate, specific_data)

        self.teachers_db.append(new_teacher)
        messagebox.showinfo("Success", f"{position} {name} created and added to the database.")
        self.show_all_teachers() # Refresh the output

    def display_results(self, teachers_list, title):
        """Clears and outputs the list of teachers to the text box."""
        self.output_text.delete("1.0", "end")
        output = f"--- {title} ({len(teachers_list)} people) ---\n\n"
        
        if not teachers_list:
            output += "Database is empty or no teachers found matching filter."
            self.output_text.insert("end", output)
            return

        for i, t in enumerate(teachers_list, 1):
            salary = t.calculate_salary()
            
            common_info = t.get_common_info()
            department_specific_info = t.get_department_info()
            
            if isinstance(t, Professor):
                status = t.get_status()
            elif isinstance(t, AssocProf):
                status = t.check_experience_level()
            else:
                status = "Unknown Position"
                
            output += (
                f"[{i}] Position: {t.__class__.__name__.upper()}\n"
                f"{common_info}\n"
                f"{department_specific_info}\n"
                f"Salary: {salary} UAH\n"
                f"Custom Method: {status}\n"
                f"Is Highly Paid: {'Yes' if t.is_highly_paid() else 'No'}\n"
                "----------------------------------------\n"
            )
        
        self.output_text.insert("end", output)

    def show_all_teachers(self):
        """Outputs full database or applies filter based on ComboBox."""
        
        filter_dept = self.search_dept.get()
        
        if filter_dept == "Show All":
            results = self.teachers_db
            title = "FULL TEACHERS DATABASE"
        else:
            # Apply filter
            results = [t for t in self.teachers_db if t.department == filter_dept]
            title = f"SEARCH RESULTS (Department: {filter_dept})"
            
        self.display_results(results, title)

# ----------------------------------------------------
# 5. MAIN ENTRY POINT
# ----------------------------------------------------
if __name__ == "__main__":
    app = TeacherApp()
    app.mainloop()