# Бинарный поиск работает только в том случае, 
# если список отсортирован


# Функция binary_search получает отсортированный массив и значение.
# Если значение присутствует в массиве, то функция возвращает его позицию

def binary_search(list,item):
    low = 0             # Граница
    high = len(list)-1  # Граница

    while low <= high:          # Пока эта часть не сократится до одного элемента...
        mid = (low + high) // 2  # проверяем средний элемент
        guess = list[mid]
        if guess == item:   # Значение найдено
            return mid
        if guess > item:    # Много
            high = mid - 1
        else:               # Мало
            low = mid + 1
    return None     # Значение не существует



if __name__ == '__main__': 
    my_list = [1, 3, 5, 7, 9]
    print(binary_search(my_list,9)) # -> 4
    print(binary_search(my_list,2)) # -> None, т.е. признак того, что элемент не найден
