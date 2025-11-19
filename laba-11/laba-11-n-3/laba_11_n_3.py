from typing import Iterator

def float_range(start: float, stop: float, step: float) -> Iterator[float]:
    
    if step == 0:
        raise ValueError("Step cannot be zero")

    current = start
    
    precision = 10 

    while True:
        if step > 0 and current >= stop:
            break
        if step < 0 and current <= stop:
            break

        yield float(round(current, precision))

        current += step

if __name__ == "__main__":
    print("--- Test 1: ---")
    print(list(float_range(1.0, 2.0, 0.3)))

    print("\n--- Test 2: ---")
    print(list(float_range(5.0, 3.0, -0.5)))

    print("\n--- Test 3: ---")
    gen = float_range(0.0, 1.0, 0.1)
    print([next(gen) for _ in range(3)])

    print("\n--- Test 4: ---")
    print(list(float_range(0.0, 0.0, 1.0)))

    print("\n--- Test 5: ---")
    print(list(float_range(1.0, 2.0, -1.0)))