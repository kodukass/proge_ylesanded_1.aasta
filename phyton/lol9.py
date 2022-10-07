from easygui import *

# msgbox("lol")
# 
# from easygui import *
#  
# nupud = ["lihtne","ok","keeruline"]
# vajutati = buttonbox("Programmeerimine on ", choices = nupud)
# msgbox("Te arvate, et programmeerimine on " + vajutati + "!")
# 
 
nimi = enterbox("Palun sisesta oma nimi: ")
vanus = integerbox("Palun sisesta oma vanus: ", lowerbound = 1, upperbound = 120)
aadress = enterbox("Palun sisesta oma aadress: ")
 
failinimi = filesavebox()
 
f = open(failinimi, "w")
f.write(nimi + "\n")
f.write(str(vanus) + "\n")
f.write(aadress + "\n")
f.close()