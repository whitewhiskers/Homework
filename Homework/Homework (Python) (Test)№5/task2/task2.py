# Задайте натуральное число N. Напишите программу, 
# которая составит список простых множителей числа N
# Для того, чтобы разложить составное число 3969 на простые множители — необходимо представить его в виде произведения простых чисел. Таким образом:
# 3969: 3
# 1323: 3
# 441: 3
# 147: 3
# 49: 7
# 7: 7

number = int(input('Введите натуральное число: '))
list = []
i = 2
while int(number) != 1:
    if int(number) % i == 0:
        number = int(number / i)
        list.append(i)
        i = 1
    i+=1
print (list)
    



