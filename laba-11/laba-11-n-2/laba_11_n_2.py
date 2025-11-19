class Countdown:
    def __init__(self, start: int):
        self.current = start

    def __iter__(self):
        return self

    def __next__(self):
        if self.current < 0:
            raise StopIteration

        value_to_return = self.current

        self.current -= 1

        return value_to_return

if __name__ == "__main__":
    print("--- laba-11-n-2 ---")
    c = Countdown(5)
    for n in c:
        print(n, end=" ")
    print("\n")

    print("---  ---")
    print(f"list(Countdown(3)): {list(Countdown(3))}")
    print(f"list(Countdown(0)): {list(Countdown(0))}")
    print(f"list(Countdown(-3)): {list(Countdown(-3))}")
