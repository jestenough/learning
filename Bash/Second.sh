#!/bin/bash

use="-------------------------------------------------"

echo $use
echo "I'm the last neuromantic in this electronic Paradise"
echo $use


for var in first second third fourth fifth
do
  echo The  $var item
done
echo $use

for var in first "the second" "the third" "I’ll do it"
do
  echo "This is: $var"
done
echo $use


file="First.sh"
IFS=$'\n'
for var in $(cat $file)
do
  echo " $var"
done
echo $use


for file in /home/rteff/*
do
  if [ -d "$file" ]
  then
    echo "$file is a directory"
  elif [ -f "$file" ]
  then
    echo "$file is a file"
  fi
done
echo $use


for (( i=1; i <= 10; i++ ))
do
  echo "number is $i"
done
echo $use


for (( a = 1; a <= 2; a++ ))
do
  echo "Start $a:"
  for (( b = 1; b <= 2; b++ ))
  do
    echo "    Inner loop: $b"
    for (( c = 1; c <= 2; c++ ))
    do
      echo "        Inner inner loop: $c"
    done
  done
done
echo $use


for (( var1 = 1; var1 < 15; var1++ ))
do
  if [ $var1 -gt 5 ] && [ $var1 -lt 10 ]
  then
    continue
  fi
echo "Iteration number: $var1"
done
echo $use


for (( a = 1; a < 10; a++ ))
do
  echo "Number is $a"
  done > Test.txt
echo "finished"



