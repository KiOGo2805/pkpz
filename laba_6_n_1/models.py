from abc import ABC, abstractmethod

# --------------------------
# ����������� ������� ����: �������� (Vykladach)
# --------------------------
class Vykladach(ABC):
    
    def __init__(self, name: str, kafedra: str, rate: float):
        self.name = name
        self.kafedra = kafedra
        self.rate = rate
        self.base_salary = 15000

    @abstractmethod
    def calculate_salary(self) -> float:
        pass

    @abstractmethod
    def get_kafedra_info(self) -> str:
        pass

    def get_common_info(self) -> str:
        return (f"��'�: {self.name}\n"
                f"�������: {self.kafedra}\n"
                f"������: {self.rate:.2f}")

    def is_highly_paid(self) -> bool:
        return self.calculate_salary() > 30000

# --------------------------
# ��ղ���� ���� 1: �������� (Profesor)
# --------------------------
class Profesor(Vykladach):
    
    def __init__(self, name: str, kafedra: str, rate: float, has_doctoral: bool):
        super().__init__(name, kafedra, rate)
        self.has_doctoral = has_doctoral
        self.prof_bonus = 0.5

    def calculate_salary(self) -> float:
        salary = self.base_salary * self.rate
        if self.has_doctoral:
             salary *= (1 + self.prof_bonus)
        return round(salary, 2)

    def get_kafedra_info(self) -> str:
        return f"������: ��������. ������: {'������ ����' if self.has_doctoral else '�������� ���� (��� �������)'}"

    def get_status(self) -> str:
        return f"������: �������� ({'� ������ ����������' if self.has_doctoral else '��������-�����������'})"

# --------------------------
# ��ղ���� ���� 2: ������ (Dotsent)
# --------------------------
class Dotsent(Vykladach):
    
    def __init__(self, name: str, kafedra: str, rate: float, years_experience: int):
        super().__init__(name, kafedra, rate)
        self.years_experience = years_experience
        self.docent_bonus_per_year = 0.01

    def calculate_salary(self) -> float:
        salary = self.base_salary * self.rate
        experience_multiplier = 1 + (self.years_experience * self.docent_bonus_per_year)
        return round(salary * experience_multiplier, 2)

    def get_kafedra_info(self) -> str:
        return f"������: ������. ��������� �����: {self.years_experience} ����."

    def check_experience_level(self) -> str:
        if self.years_experience >= 10:
            return "г���� ������: �������"
        elif self.years_experience >= 5:
            return "г���� ������: �������"
        else:
            return "г���� ������: ����������"