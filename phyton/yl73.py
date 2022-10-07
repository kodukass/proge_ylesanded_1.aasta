from easygui import *

täisarv1 = integerbox("Sisestage esimene täisarv lõigus 1-10: ", lowerbound = 1, upperbound = 120)
täisarv2 = integerbox("Sisestage teine täisarv lõigus 1-10: ", lowerbound = 1, upperbound = 120)
nupud = ["+","-","*"]
vajutati = buttonbox("Vajutage tehe: ", choices = nupud)
i=0
if nupud == "+":
    i=i+täisarv1+täisarv2
elif nupud == "-":
    i=i-täisarv1-täisarv2
elif nupud == "*":
    i=i+täisarv1*täisarv2

msgbox("Tehte tulemus on "+str(i)+". ")
# msgbox("lol")
#  
# nupud = ["lihtne","ok","keeruline"]
# vajutati = buttonbox("Programmeerimine on ", choices = nupud)
# msgbox("Te arvate, et programmeerimine on " + vajutati + "!")
# 
# 
# nimi = enterbox("Palun sisesta oma nimi: ")
# vanus = integerbox("Palun sisesta oma vanus: ", lowerbound = 1, upperbound = 120)
# aadress = enterbox("Palun sisesta oma aadress: ")
#  
# failinimi = filesavebox()
#  
# f = open(failinimi, "w")
# f.write(nimi + "\n")
# f.write(str(vanus) + "\n")
# f.write(aadress + "\n")
# f.close()