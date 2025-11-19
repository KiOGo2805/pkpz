from typing import Iterator

def walk_tree(data: dict) -> Iterator[str]:
    
    for key, value in data.items():
        yield key
        
        if isinstance(value, dict):
            yield from walk_tree(value)

if __name__ == "__main__":
    print("--- Test 1 ---")
    data1 = {
        "a": {
            "b": {
                "c": 1
            }
        },
        "d": 2
    }
    print(f"Result: {list(walk_tree(data1))}")

    print("\n--- Test 2 ---")
    data2 = {
        "x": {"y": {"z": {}}}, 
        "m": {"n": 42}
    }
    print(f"Result: {list(walk_tree(data2))}")