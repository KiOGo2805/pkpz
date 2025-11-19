def filter_even_numbers(nums: list[int]) -> list[int]:
    return [num for num in nums if num % 2 == 0]

if __name__ == "__main__":
    print("--- laba-11-n-1 ---")
    
    try:
        user_input = input("Type int numbers: ")
        
        number_list = [int(x) for x in user_input.split()]
        
        result_list = filter_even_numbers(number_list)
        
        print(f"Def list: {number_list}")
        print(f"Filtred list: {result_list}")
        
    except ValueError:
        print("(>_<)")
