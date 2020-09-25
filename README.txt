Ruben Londono 
Frederic-Alexandre Lefebvre
link to github: https://github.com/ruben563/WordUnscrambler
our videos will be posted on moodle.. sorry if any inconveniance

PROGRAM

we created a do while loop, so do -> ask wheter manual or file -> then enter 
words or file link -> response.  Then if the user wants to start again 
while user enters y it starts again.

Also created a bool temp to make sure that the input is either m or f, when tru
is goes through the app, then gets out of loop.

-------------------------------------------------

ExecuteScrambledWordsManualEntryScenario() ->

a string to read the words manually written

char array to get the commas and spaces 
then create a string array to store the words without commas and spaces
then display the matched words with the DisplayMatchedUnscrambledWords() method

---------------------------------------------------

ExecuteScrambledWordInFileScenario() ->
variable to get the file link inserted by the user
to access the filereader created a string array to send file words to be read
display the matched words

----------------------------------------------------

DisplayMatchedUnscrambledWords() ->

string array to read words in wordlist.txt
call a word matcher method, to get a list of MatchedWord structs
if any words are part of the word matcher print them
foreach to access all the words and print them
else prinnt nothing

===============================================================

MATCHEDWORD

getters and setters to get the two matched words

===============================================================

WORDMATCHER

create a lsit from matchedWord and make sure the two getter match
create a second list from matchedWord

get the words using a 2 foreach
if they match add them to the list
else if create astring array to store word in, sort it and then
add them back to string array. If they matych add to to list.
else nothing

=====================================================================

FILEREADER

create a string array to acceess the words inside to file, the arraey
contains a string to hold the filename;
try to get words inside the file, foreach word in file return to file
catch errors in case
return the string array

======================================================================

CONSTANTS

here lie all the sstring questions in public void methods, for enter m or f,
enter the word, enter the file link and would you like to continue

=========================================================================
