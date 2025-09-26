import random

def generate_train(wagons, seats):
    return [[random.choices([0, 1], weights=[1, 9])[0] for _ in range(seats)]
            for _ in range(wagons)]

def print_train(train):
    print("Train layout (1 = taken, 0 = free):")
    for i, wagon in enumerate(train, start=1):
        print(f"Wagon {i}: {' '.join(map(str, wagon))}")

def find_full_wagons(train):
    return [i+1 for i, wagon in enumerate(train)
            if all(seat == 1 for seat in wagon)]

def main():
    wagons = 10
    seats = 20

    train = generate_train(wagons, seats)
    print_train(train)

    full_wagons = find_full_wagons(train)
    if full_wagons:
        print("\nFully occupied wagons:", full_wagons)
    else:
        print("\nNo fully occupied wagons.")

main()
