from abc import ABC, abstractmethod

# --------------------------
# АБСТРАКТНИЙ БАЗОВИЙ КЛАС: ВИКЛАДАЧ (Vykladach)
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
        return (f"Ім'я: {self.name}\n"
                f"Кафедра: {self.kafedra}\n"
                f"Ставка: {self.rate:.2f}")

    def is_highly_paid(self) -> bool:
        return self.calculate_salary() > 30000

# --------------------------
# ПОХІДНИЙ КЛАС 1: ПРОФЕСОР (Profesor)
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
        return f"Посада: Професор. Ступінь: {'Доктор наук' if self.has_doctoral else 'Кандидат наук (без доктора)'}"

    def get_status(self) -> str:
        return f"Статус: Професор ({'з правом керівництва' if self.has_doctoral else 'викладач-консультант'})"

# --------------------------
# ПОХІДНИЙ КЛАС 2: ДОЦЕНТ (Dotsent)
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
        return f"Посада: Доцент. Загальний досвід: {self.years_experience} років."

    def check_experience_level(self) -> str:
        if self.years_experience >= 10:
            return "Рівень досвіду: Високий"
        elif self.years_experience >= 5:
            return "Рівень досвіду: Середній"
        else:
            return "Рівень досвіду: Початковий"