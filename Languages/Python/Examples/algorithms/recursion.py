def countdown(i):
    """Бесконечная рекурсия"""
    print(i)
    countdown(i - 1)


def countdown2(i):
    """Пример обычной рекурсии, которая напечатает все цифры от заданной до единицы"""
    print(i)
    if i <= 1:  # Базовый случай
        return
    else:  # Рекурсивный случай
        countdown2(i - 1)


def sum(user_list):
    """Рекурсивный подсчет суммы элементов в списке"""
    if not user_list:
        return 0
    return user_list[0] + sum(user_list[1:])


def count(user_list):
    """Рекурсивный подсчет количества элементов в списке"""
    if not user_list:
        return 0
    return 1 + count(user_list[1:])


def max_value(user_list):
    """Рекурсивный поиск максимального числа в списке"""
    if len(user_list) == 2:
        return user_list[0] if user_list[0] > user_list[1] else user_list[1]
    sub_max = max_value((user_list[1:]))
    return user_list[0] if user_list[0] > sub_max else sub_max


if __name__ == '__main__':
    pass
