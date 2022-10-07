# from random import randint
# number= randint(1,20)
# arvamisi=0
# while True:
#     küsitudNummer=int(input("paku nummer"))
#     arvamisi +=1
#     if küsitudNummer == number:
#         print("Tubli laps")
#         break
#     elif arvamisi == 5:
#         print("kaotasid")
#     elif küsitudNummer > number:
#         print("Liiga suur")
#     else:
#         print("liiga väike")

# number=1
# while number in range (1,21):
#     print(number)
#     number +=1

# kombinatsioone=0
# for y in range(1,21):
#     for z in range (1,21):
#         for x in range(1,21):
#             print(z ,"-", x ,"-",y)
#             kombinatsioone+=1
# print("Kokku leiti ",kombinatsioone," kombinatsiooni")
# 
# 
# from time import sleep
#  
# def loe_alla(algus,lõpp):
#     i = 10
#     while algus >= lõpp:
#         print(algus)
#         algus -= 1
#         sleep(1)
#  
# loe_alla(4,2)
# loe_alla(500,499)
# 
# def ruutu(arv):
#     return arv**2
# print(ruutu(55))

# def failistSõnejärjendisse(failiNimi):
#     fail=open(failiNimi, encoding="UTD-82")
#     tulemus = []
#     for rida in fail:
#         tulemus += [int(rida)]  # alternatiivselt: järjend.append(rida.strip())
#                                    # strip() võtab lõpust ära reavahetuse
#     fail.close()
#     return järjend
# 
# failinimi = input("Sisestage failinimi ")
# fail = open(failinimi, encoding="UTF-8")
# sõned = failistSõnejärjendisse(fail)
# print(sõned)
# print(sõned[3])


# def kasKiiruseÜletamine(kiirus, piirkiirus = 90):
#     return kiirus > piirkiirus
#  
# print(kasKiiruseÜletamine(100))
# print(kasKiiruseÜletamine(90, 70))
# 
# print("Väljastatav tekst ", end = "lõppu juurde")
# 
# print("Tervitus",end="\n",sep=" ")


# def summaFunktsioon(a, b, c):
#     summa = a + b + c + gm
#     return summa
#  
# gm = 17   # globaalne muutuja
# print(summaFunktsioon(1, 2, 3))


# from turtle import *
#  
# def ruut():                # Defineerime funktsiooni nimega ruut
#     i = 0
#     while (i < 4):
#         forward(100)
#         left(90)
#         i = i + 1
#  
# for i in range(45,360,45):
#     ruut()
#     right(i)
# ruut()                     # Kutsume funktsiooni ruut välja. Kilpkonn joonistab ruudu küljega 100 pikslit
# right(45)                  # Pöörame paremale 45°
# ruut()                     # Kutsume uuesti funktsiooni ruut välja
#  
# exitonclick()


# from turtle import *
#  
# def ruut(n):               # Defineerime funktsiooni ruudu joonistamiseks
#     i = 0
#     while (i < 4):
#         fd(n)
#         lt(90)
#         i = i + 1
#  
# pencolor("#32CD32")        # Kilpkonn muudab pliiatsi värvi laimiroheliseks
# fillcolor("red")           # Kilpkonn muudab täitevärvi punaseks
# begin_fill()               # Kilpkonn alustab ringi värvimist
# circle(100)                # Kilpkonn joonistab ringi raadiusega 100 pikslit
# end_fill()                 # Kilpkonn lõpetab ringi värvimise
#  
# up()                       # Pliiats üles
# fd(300)                    # Kilpkonn liigub edasi 300 pikslit
# lt(90)                     # Kilpkonn pöörab 90° vasakule
# fd(50)
# down()                     # Pliiats alla
#  
# pencolor("red")            # Kilpkonn muudab pliiatsi värvi punaseks
# fillcolor("#32CD32")       # Kilpkonn muudab täitevärvi laimiroheliseks
# begin_fill()
# ruut(100)                  # Kilpkonn joonistab ruudu küljega 100 pikslit
# end_fill()
#  
# bgcolor("pale turquoise")  # Muudame taustavärvi helesiniseks
#  
# exitonclick()

# from turtle import *
# def hulknurk(n):    
#     i = 0
#     nurk = 360 / n         # Arvutatakse kilpkonna pööramise nurga suurus
#     while (i < n):
#         forward(100)
#         left(nurk)
#         i = i + 1
#  
# hulknurk(5)
# exitonclick()