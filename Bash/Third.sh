#! /bin/bash

use="------------------------------------"

echo $use
echo My task is to send head requests
echo $use

#echo $0
#echo $1
#echo $2

#total=$[ $1 + $2 ]
#echo The first parameter is $1.
#echo The second parameter is $2.
#echo The sum is $total.


# echo Hello $1, how do you do

# if [ -n "$1" ]
#  then
#  echo Hello $1.
# else
#  echo "No parameters found. "
# fi


# echo There were $# parameters passed.

# echo The last parameter was ${!#}


#count=1
#for param in "$*"
#  do
#    echo "\$* Parameter #$count = $param"
#    count=$(( $count + 1 ))
#  done
#
#count=1
#for param in "$@"
#  do
#    echo "\$@ Parameter #$count = $param"
#    count=$(( $count + 1 ))
#  done

#count=1
#while [ -n "$1" ]
#do
#  echo "Parameter #$count = $1"
#  count=$(( $count + 1 ))
#  shift
#done

#while [ -n "$1" ]
#do
#  case "$1" in
#    a) echo "Found the -a option" ;;
#    b) echo "Found the -b option" ;;
#   c) echo "Found the -c option" ;;
#    *) echo "$1 is not an option" ;;
#  esac
#shift
#done


#while [ -n "$1" ]
#do
#  case "$1" in
#    a) echo "Found the -a option" ;;
#    b) echo "Found the -b option";;
#    c) echo "Found the -c option" ;;
#    --) shift
#    break ;;
#    *) echo "$1 is not an option";;
#  esac
#shift
#done
#
#count=1
#for param in $@
#do
#  echo "Parameter #$count: $param"
#  count=$(( $count + 1 ))
#done


#while [ -n "$1" ]
#do
#  case "$1" in
#    -a) echo "Found the -a option";;
#    -b) param="$2"
#    echo "Found the -b option, with parameter value $param"
#    shift ;;
#    -c) echo "Found the -c option";;
#    --) shift
#    break ;;
#    *) echo "$1 is not an option";;
#    esac
#shift
#done
#
#count=1
#for param in "$@"
#do
#  echo "Parameter #$count: $param"
#  count=$(( $count + 1 ))
#done


# -a Вывести все объекты.
# -c Произвести подсчёт.
# -d Указать директорию.
# -e Развернуть объект.
# -f Указать файл, из которого нужно прочитать данные.
# -h Вывести справку по команде.
# -i Игнорировать регистр символов.
# -l Выполнить полноформатный вывод данных.
# -n Использовать неинтерактивный (пакетный) режим.
# -o Позволяет указать файл, в который нужно перенаправить вывод.
# -q Выполнить скрипт в quiet-режиме.
# -r Обрабатывать папки и файлы рекурсивно.
# -s Выполнить скрипт в silent-режиме.
# -v Выполнить многословный вывод.
# -x Исключить объект.
# -y Ответить «yes» на все вопросы


#if read -t 5 -p "Enter your name: " name
#then
#  echo "Hello $name, welcome to my script"
#else
#  echo "Sorry, too slow! "
#fi


#read -s -p "Enter your password: " pass
#echo "Is your password really $pass? "



