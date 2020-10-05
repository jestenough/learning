# Сортировка массива по возрастанию

# Поиск наименьшего элемента в массиве
def findSmallest(array):
    smallest = array[0]   # Для хранения наименьшего ззначения
    smallest_index = 0
    for i in range(1, len(array)):
        if array[i] < smallest:
            smallest = array[i]
            smallest_index = i
    return smallest_index

# Функция сортировки выбором
def selectionSort(array):
    newArray = []
    while (len(array)):
        smallest = findSmallest(array)          # Находит наименьший элемент в массиве
        newArray.append(array.pop(smallest))    # и добавляет его в новый массив
    return newArray


if __name__ == '__main__': 
    print(selectionSort([5,3,6,2,10])) # -> [2, 3, 5, 6, 10]
