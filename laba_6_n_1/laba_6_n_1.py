import tkinter as tk
from tkinter import messagebox, ttk
from abc import ABC, abstractmethod

# ----------------------------------------------------
# 1. ABSTRACT BASE CLASS: TEACHER
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
# 4. GUI APPLICATION CLASS (using standard Tkinter)
# ----------------------------------------------------
class TeacherApp(tk.Tk):
    def __init__(self):
        super().__init__()
        self.title("Lab 6: Abstract Classes")
        self.geometry("600x450")
        self.resizable(False, False)
        
        self.department_list = ["Software Engineering", "Cybersecurity", "Mathematics", "Physics"]
        
        self.teachers_db = [
            Professor("Ivanov A.A.", "Software Engineering", 1.0, True),
            AssocProf("Petrova O.V.", "Mathematics", 0.75, 8),
            Professor("Sydorenko V.V.", "Cybersecurity", 0.5, False),
            AssocProf("Melnyk I.S.", "Software Engineering", 1.0, 12),
        ]
        
        self.setup_ui()

    def setup_ui(self):
        
        # Frame for controls
        control_frame = ttk.Frame(self, padding="10")
        control_frame.pack(pady=10)

        # Department ComboBox
        ttk.Label(control_frame, text="Search Department:").pack(side="left", padx=5)
        self.department_search = ttk.Combobox(control_frame, values=self.department_list, width=25)
        self.department_search.set(self.department_list[0])
        self.department_search.pack(side="left", padx=10)

        # Buttons
        ttk.Button(control_frame, text="Show All Database", command=self.show_all_teachers).pack(side="left", padx=5)
        ttk.Button(control_frame, text="Search by Department", command=self.search_by_department).pack(side="left", padx=5)

        # Output Text Area
        ttk.Label(self, text="Results Output:").pack(pady=(10, 0))
        
        self.output_text = tk.Text(self, height=18, width=70)
        self.output_text.pack(padx=20, pady=10)

        self.show_all_teachers()

    def display_results(self, teachers_list, title):
        self.output_text.delete("1.0", "end")
        output = f"--- {title} ({len(teachers_list)} people) ---\n\n"
        
        if not teachers_list:
            output += "No teachers found."
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
        self.display_results(self.teachers_db, "FULL TEACHERS DATABASE")

    def search_by_department(self):
        department_name = self.department_search.get()
        
        results = [
            t for t in self.teachers_db if t.department == department_name
        ]
        
        self.display_results(results, f"SEARCH RESULTS (Department: {department_name})")

# ----------------------------------------------------
# 5. MAIN ENTRY POINT
# ----------------------------------------------------
if __name__ == "__main__":
    app = TeacherApp()
    app.mainloop()