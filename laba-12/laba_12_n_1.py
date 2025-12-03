def sort_by_age(people: list[dict]) -> list[dict]:
    return sorted(people, key=lambda person: person["age"])

if __name__ == "__main__":
    print("--- Sorting by Age ---")
    
    people_list = [
        {"name": "Alice", "age": 30},
        {"name": "Bob", "age": 25},
        {"name": "Eve", "age": 35}
    ]
    
    print("Original list:")
    for p in people_list:
        print(p)
        
    sorted_people = sort_by_age(people_list)
    
    print("\nSorted list (by age):")
    for p in sorted_people:
        print(p)