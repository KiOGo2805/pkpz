import customtkinter as ctk
from tkinter import messagebox
# Імпортуємо класи логіки з нашого файлу models.py
from models import Profesor, Dotsent 

# ----------------------------------------------------
# НАЛАШТУВАННЯ ІНТЕРФЕЙСУ
# ----------------------------------------------------
ctk.set_appearance_mode("System")  # Тема: системна (або "Dark", "Light")
ctk.set_default_color_theme("blue")

class VykladachApp(ctk.CTk):
    def __init__(self):
        super().__init__()
        self.title("Лабораторна 6: Абстрактні класи (Python)")
        self.geometry("700x600")
        self.resizable(False, False)
        
        # Список доступних кафедр для ComboBox
        self.kafedra_list = ["Програмна інженерія", "Кібербезпека", "Математика", "Фізика"]
        
        # База викладачів (масив) - ініціалізація об'єктів
        self.teachers_db = [
            Profesor("Іванов А.А.", "Програмна інженерія", 1.0, True),
            Dotsent("Петрова О.В.", "Математика", 0.75, 8),
            Profesor("Сидоренко В.В.", "Кібербезпека", 0.5, False),
            Dotsent("Мельник І.С.", "Програмна інженерія", 1.0, 12),
        ]
        
        self.setup_ui()

    def setup_ui(self):
        """Створює елементи графічного інтерфейсу."""
        # -------------------
        # Секція управління та пошуку
        # -------------------
        control_frame = ctk.CTkFrame(self)
        control_frame.pack(pady=20, padx=20, fill="x")

        # Комбобокс для вибору кафедри для пошуку
        ctk.CTkLabel(control_frame, text="Кафедра для пошуку:").pack(side="left", padx=10, pady=10)
        self.kafedra_search = ctk.CTkComboBox(control_frame, values=self.kafedra_list, width=200)
        self.kafedra_search.set(self.kafedra_list[0])
        self.kafedra_search.pack(side="left", padx=10, pady=10)

        # Кнопки
        ctk.CTkButton(control_frame, text="Показати всю базу", command=self.show_all_teachers).pack(side="left", padx=10, pady=10)
        ctk.CTkButton(control_frame, text="Пошук за кафедрою", command=self.search_by_kafedra).pack(side="left", padx=10, pady=10)

        # -------------------
        # Секція виводу результатів
        # -------------------
        ctk.CTkLabel(self, text="Результати виводу:", anchor="w").pack(padx=20, pady=(10, 0), fill="x")
        
        self.output_text = ctk.CTkTextbox(self, height=400, width=660)
        self.output_text.pack(padx=20, pady=10)

        # Заповнюємо базу при першому запуску
        self.show_all_teachers()

    # ----------------------------------------------------
    # МЕТОДИ КЕРУВАННЯ ЛОГІКОЮ
    # ----------------------------------------------------

    def display_results(self, teachers_list, title):
        """Очищує та виводить список викладачів у текстове поле."""
        self.output_text.delete("1.0", "end")
        output = f"--- {title} ({len(teachers_list)} осіб) ---\n\n"
        
        if not teachers_list:
            output += "Викладачів не знайдено."
            self.output_text.insert("end", output)
            return

        for i, t in enumerate(teachers_list, 1):
            salary = t.calculate_salary()
            
            # Використання поліморфізму (виклики абстрактних методів)
            common_info = t.get_common_info()
            kafedra_specific_info = t.get_kafedra_info()
            
            # Використання власного методу кожного похідного класу
            if isinstance(t, Profesor):
                status = t.get_status()
            elif isinstance(t, Dotsent):
                status = t.check_experience_level()
            else:
                status = "Невідома посада" # Якщо буде інший клас
                
            output += (
                f"[{i}] Посада: {t.__class__.__name__.upper()}\n"
                f"{common_info}\n"
                f"{kafedra_specific_info}\n"
                f"Зарплата: {salary} UAH\n"
                f"Власний метод: {status}\n"
                f"Висока оплата: {'Так' if t.is_highly_paid() else 'Ні'}\n"
                "----------------------------------------\n"
            )
        
        self.output_text.insert("end", output)

    def show_all_teachers(self):
        """Виводить повну інформацію з усієї бази на екран."""
        self.display_results(self.teachers_db, "ПОВНА БАЗА ВИКЛАДАЧІВ")

    def search_by_kafedra(self):
        """Організовує пошук викладачів, які викладають на заданій кафедрі."""
        kafedra_name = self.kafedra_search.get()
        
        # Фільтруємо базу за вибраною кафедрою
        results = [
            t for t in self.teachers_db if t.kafedra == kafedra_name
        ]
        
        self.display_results(results, f"РЕЗУЛЬТАТИ ПОШУКУ (Кафедра: {kafedra_name})")

# ----------------------------------------------------
# ТОЧКА ВХОДУ В ПРОГРАМУ
# ----------------------------------------------------
if __name__ == "__main__":
    app = VykladachApp()
    app.mainloop()
