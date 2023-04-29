# Final_Test
Программа из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.

## Принцип работы:
1. Пользователь вводит с клавиатуры строки, который записывается в массив "array"

**Важно**: ввод строк осуществляется строго **через запятую**

2. Далее включается первый цикл "for" на количество итераций равное количеству элементов массива "array", данный цикл проходит по эелементам массива "array" и записывает в переменную "count" количество элементов, чья длина не превышает 3 символа.

3. Далее заводится массив "result_array" с длиной "count", который будет выводом.

4. Затем второй цикл "for" ещё раз проходит по массиву "array" и записывает элементы, чья длина не превышает 3 символа, в "result_array"

5. Далее массив "result array" выводится в консоль

Блок-схема кода:

![Блок-схема.png](Блок-схема.png)