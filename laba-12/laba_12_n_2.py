def filter_long_words(words: list[str]) -> list[str]:
    """
    Фільтрує список слів, залишаючи лише ті, що довші за 3 символи.
    Використовує вбудовану функцію filter().
    """
    # filter(функція_умови, список) повертає ітератор.
    # lambda w: len(w) > 3 — це анонімна функція, яка повертає True, якщо довжина слова > 3.
    # list(...) перетворює результат фільтрації назад у список.
    return list(filter(lambda w: len(w) > 3, words))

# --- Тестування (Приклади з завдання) ---
if __name__ == "__main__":
    print("--- Test 1 ---")
    test1 = ["a", "the", "code", "Python", "is", "fun"]
    # Очікується: ['code', 'Python']
    print(f"Input: {test1}")
    print(f"Result: {filter_long_words(test1)}")

    print("\n--- Test 2 ---")
    test2 = ["cat", "dog", "fish", "go", "egg"]
    # Очікується: ['fish'] (слова з 3 літер не включаються)
    print(f"Input: {test2}")
    print(f"Result: {filter_long_words(test2)}")

    print("\n--- Test 3 ---")
    test3 = ["", "aa", "bbb", "cccc", "ddddd"]
    # Очікується: ['cccc', 'ddddd']
    print(f"Input: {test3}")
    print(f"Result: {filter_long_words(test3)}")

    print("\n--- Test 4 ---")
    test4 = []
    # Очікується: []
    print(f"Input: {test4}")
    print(f"Result: {filter_long_words(test4)}")