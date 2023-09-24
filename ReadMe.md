# Итоговая контрольная работа 
Программа создает новый массив строк используя введенный.
Выбирая из введенного массива слова или символы не более трех. То есть результирующие строки будут длинной не более трех символов.

## Работа программы
При запуске программа выводит название и выбор как вводить данные либо ввод с клавиатуры, либо ввод массива который задан на сайте gb.ru.

Ввод с клавиатуры достаточно разделять символы через пробел, причем если случайно будет введено более одного пробела программа все равно будет работать корректно.

Для визуализации добавлен небольшой интерфейс. И ввод значения, которое отвечает за количество символов в результирующем массиве, решено не добавлять чтобы не засорять интерфейс пользователя.

### Для разработчика
Основная программа описана в методе 
```
void returnArr(string[] begin, int sizeWord)
```
где\
```string[] begin``` - заданный массив строк,\
```int sizeWord``` - количество символов в результирующем массиве.

Основную программу вызывает два метода:
```
void standartArr()
void writeArr()
```
первый метод хранит данные из стандартных массивов и передает на основную программу, второй метод получает строку введенную с клавиатуры и разбивает на отдельные слова.

Метод 
```
void start()
```
запускается в основной программе, и дает на выбор пользователю, либо ввод масива с клавиатуры, либо стандартные массивы.