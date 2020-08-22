#! /usr/bin/bash

echo "I'm the track designer, collective and human"
echo My task is to overwhelm people stack

pwd >> fourth_test
ls >> fourth_test

#ls –l logs  2> errorcontent 1> correctcontent

#echo "This is an error" >&2
#echo "This is normal output"

#exec 2>myerror
#echo "This is the start of the script"
#echo "now redirecting all output to another location"
#exec 1>myfile
#echo "This should go to the myfile file"
#echo "and this should go to the myerror file" >&2

exec 6<&0
exec 0< fourth_test
count=1
while read line
do
  echo "Line #$count: $line"
  count=$(( $count + 1 ))
done
exec 0<&6
read -p "Are you done now? " answer
case $answer in
y) echo "Goodbye";;
n) echo "Sorry, this is the end.";;
esac

ls -al badfile anotherfile 2> /dev/null

cat /dev/null > fourth_test

