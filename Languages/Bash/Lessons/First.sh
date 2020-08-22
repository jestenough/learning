#! /bin/bash

# wow u a so cool
usability="-------------------------------------------"

echo $usability
echo -e "\033[32mIf u have binary code \033[31m u needn't notes\033[0m"
echo $usability

echo Hey, what time is it?
date
echo $usability

echo Home for the current user is: $HOME
echo $usability

echo $USER have \$1 in pocket
echo $usability

mydir=$(pwd)
echo $mydir
echo $usability

var1=$((5+5))
echo $var1
echo $usability

if pwd
then
  echo It works
fi
echo $usability

user=Test
if grep $user /etc/passwd
then
  echo The user $user Exists
else
  echo "The user $user doesn't exist"
fi
echo $usability

if grep $user /etc/passwd
then 
  echo "The user $user Exists"
elif ls /home
then
  echo "The user doen't exist but anyway there is a directory under /home"
fi
echo $usability 


# -eq  -- n1 = n2
# -ge  -- n1 >= n2
# -gt  -- n1 > n2
# -le  -- n1 <= n2
# -lt  -- n1 < n2 
# -ne  -- n1 != n2
value=5
if [ $value -gt 4 ]
then
  echo The test value $value is greater than 4
else 
  echo The test value $value is not greater than 4
fi
echo $usability


# -n len(str1) > 0
# -z len(str1) = 0
user="rteff"
if [ $user = $USER ]
then 
  echo The user $user is the current logged in user
else
  echo The user $user isnt the current logged in user
fi
echo $usability

text1=text
text2="another text"
if [ $text1 \> "$text2" ]
then
  echo $text1 is greater than $text2
else
  echo $text1 is less than $text2
fi
echo $usability


# -d file ∃= directory
# -e file ∃
# -f file ∃= file
# -r file ∃= read
# -s file ∃!=NULL
# -w file ∃= write
# -x file ∃= +x
# -nt is file1 newer than file2
# -ot checks whether file1 is older than file2.
# -O file ∃ whether the current user owns it
# -G file ∃ Checks whether the file exists and whether its group ID matches the group ID of the current user
mydir=/home/rteff/GitHub/
if [ -d $mydir ]
then 
  echo The $mydir directory exist
  cd $mydir
  ls
else
  echo The $mydir directory does not exist
fi
echo $usability
