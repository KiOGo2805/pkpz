import customtkinter as ctk
from tkinter import messagebox
# ��������� ����� ����� � ������ ����� models.py
from models import Profesor, Dotsent 

# ----------------------------------------------------
# ������������ ����������
# ----------------------------------------------------
ctk.set_appearance_mode("System")  # ����: �������� (��� "Dark", "Light")
ctk.set_default_color_theme("blue")

class VykladachApp(ctk.CTk):
    def __init__(self):
        super().__init__()
        self.title("����������� 6: ��������� ����� (Python)")
        self.geometry("700x600")
        self.resizable(False, False)
        
        # ������ ��������� ������ ��� ComboBox
        self.kafedra_list = ["��������� ��������", "ʳ����������", "����������", "Գ����"]
        
        # ���� ���������� (�����) - ����������� ��'����
        self.teachers_db = [
            Profesor("������ �.�.", "��������� ��������", 1.0, True),
            Dotsent("������� �.�.", "����������", 0.75, 8),
            Profesor("��������� �.�.", "ʳ����������", 0.5, False),
            Dotsent("������� �.�.", "��������� ��������", 1.0, 12),
        ]
        
        self.setup_ui()

    def setup_ui(self):
        """������� �������� ���������� ����������."""
        # -------------------
        # ������ ��������� �� ������
        # -------------------
        control_frame = ctk.CTkFrame(self)
        control_frame.pack(pady=20, padx=20, fill="x")

        # ��������� ��� ������ ������� ��� ������
        ctk.CTkLabel(control_frame, text="������� ��� ������:").pack(side="left", padx=10, pady=10)
        self.kafedra_search = ctk.CTkComboBox(control_frame, values=self.kafedra_list, width=200)
        self.kafedra_search.set(self.kafedra_list[0])
        self.kafedra_search.pack(side="left", padx=10, pady=10)

        # ������
        ctk.CTkButton(control_frame, text="�������� ��� ����", command=self.show_all_teachers).pack(side="left", padx=10, pady=10)
        ctk.CTkButton(control_frame, text="����� �� ��������", command=self.search_by_kafedra).pack(side="left", padx=10, pady=10)

        # -------------------
        # ������ ������ ����������
        # -------------------
        ctk.CTkLabel(self, text="���������� ������:", anchor="w").pack(padx=20, pady=(10, 0), fill="x")
        
        self.output_text = ctk.CTkTextbox(self, height=400, width=660)
        self.output_text.pack(padx=20, pady=10)

        # ���������� ���� ��� ������� �������
        self.show_all_teachers()

    # ----------------------------------------------------
    # ������ ��������� ��ò���
    # ----------------------------------------------------

    def display_results(self, teachers_list, title):
        """����� �� �������� ������ ���������� � �������� ����."""
        self.output_text.delete("1.0", "end")
        output = f"--- {title} ({len(teachers_list)} ���) ---\n\n"
        
        if not teachers_list:
            output += "���������� �� ��������."
            self.output_text.insert("end", output)
            return

        for i, t in enumerate(teachers_list, 1):
            salary = t.calculate_salary()
            
            # ������������ ����������� (������� ����������� ������)
            common_info = t.get_common_info()
            kafedra_specific_info = t.get_kafedra_info()
            
            # ������������ �������� ������ ������� ��������� �����
            if isinstance(t, Profesor):
                status = t.get_status()
            elif isinstance(t, Dotsent):
                status = t.check_experience_level()
            else:
                status = "������� ������" # ���� ���� ����� ����
                
            output += (
                f"[{i}] ������: {t.__class__.__name__.upper()}\n"
                f"{common_info}\n"
                f"{kafedra_specific_info}\n"
                f"��������: {salary} UAH\n"
                f"������� �����: {status}\n"
                f"������ ������: {'���' if t.is_highly_paid() else 'ͳ'}\n"
                "----------------------------------------\n"
            )
        
        self.output_text.insert("end", output)

    def show_all_teachers(self):
        """�������� ����� ���������� � �񳺿 ���� �� �����."""
        self.display_results(self.teachers_db, "����� ���� �������ײ�")

    def search_by_kafedra(self):
        """��������� ����� ����������, �� ���������� �� ������ ������."""
        kafedra_name = self.kafedra_search.get()
        
        # Գ������� ���� �� �������� ��������
        results = [
            t for t in self.teachers_db if t.kafedra == kafedra_name
        ]
        
        self.display_results(results, f"���������� ������ (�������: {kafedra_name})")

# ----------------------------------------------------
# ����� ����� � ��������
# ----------------------------------------------------
if __name__ == "__main__":
    app = VykladachApp()
    app.mainloop()
