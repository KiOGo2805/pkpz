def input_array():
    n = int(input("Enter array size: "))
    arr = []
    for i in range(n):
        arr.append(int(input(f"arr[{i}] = ")))
    return arr

def average_between(arr):
    min_index = arr.index(min(arr))
    max_index = arr.index(max(arr))

    if min_index > max_index:
        min_index, max_index = max_index, min_index

    subarray = arr[min_index:max_index + 1]
    return sum(subarray) / len(subarray), min_index, max_index, arr[min_index], arr[max_index]

def print_results(arr, avg, min_index, max_index, min_val, max_val):
    print("Array:", arr)
    print(f"Min index: {min_index}, value: {min_val}")
    print(f"Max index: {max_index}, value: {max_val}")
    print(f"Average between arr[{min_index}] and arr[{max_index}] ({min_val}..{max_val}): {avg:.2f}")

def main():
    arr = input_array()
    avg, min_index, max_index, min_val, max_val = average_between(arr)
    print_results(arr, avg, min_index, max_index, min_val, max_val)

main()
