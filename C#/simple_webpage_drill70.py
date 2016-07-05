import os


file_name = '-'
while (file_name == '-'):
    file_name = input("What is the name of the file you would like to make? ")

print("Thanks. Your file {}.html will be ready soon.".format(file_name))

outputFile = open(file_name, 'w')
print("<html>" file = outputFile)
print("<head>\n <title> Wow </title>\n</head>\n" file = outputFile)
print("<body>\n" file = outputFile)
print("<p>Stay tuned for our anazing summer sale!</p>\n" file = outputFile)
print("</body" file = outputFile)
print("</html>" file = outputFile)

print('Thanks for waiting')




    