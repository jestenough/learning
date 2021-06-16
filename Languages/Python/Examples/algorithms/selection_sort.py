def find_smallest(user_list):
    """ Поиск наименьшего элемента в списке

    Функция получается список значений пользователя.
    Пробегает по всему списку и ищем минимальный элемент (путем сравнивания).
    В конечном итоге возвращает индекс минимального элемента.

    :param user_list: Список элементов пользователя
    :return:  индекс минимального элемент

    """
    smallest = user_list[0]  # Для хранения наименьшего значения
    smallest_index = 0
    for i in range(1, len(user_list)):
        if user_list[i] < smallest:
            smallest = user_list[i]
            smallest_index = i
    return smallest_index


def selection_sort(user_list):
    """ Сортировка выбором по возрастанию

    Функция создает новый список, в который каждый раз отправляется наименьший элемент в массиве из оставшихся.
    Худшее время 	О(n * n)
    Лучшее время 	О(n * n)
    Среднее время 	О(n * n)
    Затраты памяти 	О(n) всего, O(1) дополнительно

    :param user_list:  список элементов пользователя
    :return:  новый отсортированный список

    """
    newList = []
    while len(user_list):
        smallest = find_smallest(user_list)  # Находит наименьший элемент в списке
        newList.append(user_list.pop(smallest))  # извлекает и добавляет его в новый список
    return newList


if __name__ == '__main__':
    print(selection_sort([5, 3, 6, 2, 10, 3, 6]))  # -> [2, 3, 3, 5, 6, 6, 10]

