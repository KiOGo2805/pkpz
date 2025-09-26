import random

def check_hit(x, y, a, b, R):
    onCircle = (x * x + y * y == R * R)
    if onCircle:
        onRectangle = (x < 0 and y < 0 and y > (-b)) or (x > 0 and y > 0 and y < (-b))
        return "On the edge"
    
    inCircle = (x * x + y * y < R * R)
    if inCircle:
        inRectangle = (x > (-a) and x <= 0 and y >= (-b) and y <= 0)
        if inRectangle:
            onRectangle = (x == 0 or y == (-b) or y == 0)
            if onRectangle:
                return "On the edge"
            else:
                return "Yes"
        else:
            return "No"
    else:
        inRectangle = (x > 0 and x <= a and y >= 0 and y <= b)
        if inRectangle:
            onRectangle = (x == a or y == b or y == 0)
            if onRectangle:
                return "On the edge"
            else:
                return "Yes"
        else:
            return "No"

def generate_coordinates():
    x = round(random.uniform(-5, 5), 1)
    y = round(random.uniform(-4, 4), 1)
    return x, y

a = 5
b = 3
R = 4

print(f"{'Shot number':<15}{'Shot coordinates':<25}{'Result':<20}")
for i in range(1, 11):
    x, y = generate_coordinates()
    result = check_hit(x, y, a, b, R)
    print(f"{i:<15}{f'({x}, {y})':<25}{result:<20}")
