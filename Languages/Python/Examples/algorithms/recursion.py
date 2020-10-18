# через цикл
def look_for_key(main_box):
    pile = main_box.make_a_pile_to_look_through()
    while piles is not empty:
        box = pile.grab_a_box()
        for item in box:
            if item.is_a_key():
                pile.append(item)
            elif item.is_a_key():
                print("found the key!")

#через рекурсию
def look_for_key2(box):
    for item in box:
        if item.is_a_box():
            look_for_key(item)  # рекурсия
        elif item.is_a_key():
            print("found the key!")


# Бесконечная рекурсия
def countdown(i):
    print(i)
    countdown(i-1)


# обычая рекурсия
def countdown2(i):
    print(i)
    if i <= 1:  # Базовый случай
        return
    else:   # Рекурсивыный случай
        countdown2(i-1)

# countdown(5)  <-- Бесконечная 
countdown2(5)
