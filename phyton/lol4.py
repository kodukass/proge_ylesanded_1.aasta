# nimi=input("nimi plz")
# for i in range(5):
#     print("Ole tervitatud, "+nimi +", "+ str(i+1)+". korda.")


# nimi=input("Palun sisesta oma nimi: ")
# mitmes=0
# nimistr=str(nimi)
# lause="Ole tervitatud, "+ nimi+", " +mitmes+ " korda."
# while mitmes < 5:
#     mitmes += 1
#     print(lause)

# number1=0
# for i in range(10):
#     number=input("number plz: ")
#     number1=float(number1)+float(number)
# print(number1)

# number1=0
# number=0
# while float(number) >0:
#     number=input("number plz: ")
#     number1=float(number1)+float(number)
#     if number == "":
#         print(number1)

# summa=0
# while True:
#     sisestus=input("arv plz: ")
#     if sisestus == "":
#         break
#     arv=int(sisestus)
#     summa += arv
# print(summa)
# from random import randint
# number1=0
# number2=0
# õiged=0
# summa=0
# ülesanded=10
# print("Õpime arvutama. ")
# for i in range (ülesanded):
#     number1=randint(2,20)
#     number2=randint(2,20)
#     tehe=randint(1,3)
#     elif tehe==1:
#     summa = number1+number2
#     vastus=int(input("Palju on kokku "+ str(number1) +" ja " + str(number2) +" "))
#     elif vastus == number1+number2:
#         print("Tubli! ")
#         õiged+=1
#     else:
#         print("Vale, õige vastus on "+ str(summa))
#     number1==0
#     number2==0
#     ülesanded -= 1
#     elif tehe==2:
#     summa = number1+number2
#     vastus=int(input("Palju on lahku "+ str(number1) +" ja " + str(number2) +" "))
#     elif vastus == number1-number2:
#         print("Tubli! ")
#         õiged+=1
#     else:
#         print("Vale, õige vastus on "+ str(summa))
#     number1==0
#     number2==0
#     ülesanded -= 1
#     elif tehe==2:
#     summa = number1+number2
#     vastus=int(input("Palju on lahku "+ str(number1) +" ja " + str(number2) +" "))
#     elif vastus == number1-number2:
#         print("Tubli! ")
#         õiged+=1
#     else:
#         print("Vale, õige vastus on "+ str(summa))
#     number1==0
#     number2==0
#     ülesanded -= 1
#     elif tehe==3:
#     summa = number1*number2
#     vastus=int(input("Palju on lahku "+ str(number1) +" ja " + str(number2) +" "))
#     elif vastus == number1*number2:
#         print("Tubli! ")
#         õiged+=1
#     else:
#         print("Vale, õige vastus on "+ str(summa))
#     number1==0
#     number2==0
#     ülesanded -= 1
# print("Tubli töö!")
# protsen=õigeid*100/tehted
# if protsent>90:
#     print("Suurepärane")
# elif protsent>50:
#     print("Üle keskmise")
# else:
#     print("Proovi veel")
#     
    
# nädalapäevad = ["esmaspäev", "teisipäev", "kolmapäev", "neljapäev", "reede", "laupäev", "pühapäev"]
# 
# nädalapäevi=len(nädalapäevad)
# 
# print(nädalapäevad[0])
# print(nädalapäevad[-1])
# 
# linn="Tartu"
# print(linn[2])
# print(nädalapäevad[1][1])
# 
# a = ['A', 'B', 'C', 'D', 'E']
# print(a[0:2])
# print(a[:2])
# print(a[2:5])
# print(a[2:])
# print(a[-2:])
# 
# sõne1 = 'Tartu'
# print(sõne1[1:4])
# sõne2 = sõne1
# print(sõne2[-2:])
# print("Väike-Maarja"[4:9])
# 
# a = [5, 8]
# a.append(7)
# print(a)
# b = [5, 8]
# b += [7]
# print(b)
# print(min(nädalapäevad))
# 
# a = [12, 23, 34, 45, 56]
# i = 0
# while i < len(a):
#     print(a[i])
#     i += 1
#     
# a = [12, 23, 34, 45, 56]
# for el in a:        #el asemel on ka teised nimed lubatud 
#     print(el)
#     
# for i in range(0, 13, 2):
#     print(i)
#     
# for i in range(4, -5, -3):
#     print(i)
#     
# fail = open("andmed.txt", encoding="UTF-8")
# for rida in fail:
#     print("Lugesin sellise rea: " + rida)
# fail.close()
# 
# fail = open("jooks.txt", encoding="UTF-8")
# kokku = 0
# jooksud = []
# for rida in fail:
#     jooksud.append(float(rida))
#     # teine variant: jooksud += [float(rida)]     
# fail.close()
# print(jooksud[4])
# 
# 
# 
# from time import sleep
#  
# keel = int(input("1) Eesti 2) English 3) Deutsche "))
#  
# if keel == 2:
#     failinimi = "eng.txt"
# elif keel == 3:
#     failinimi = "ger.txt"
# else:
#     failinimi = "est.txt"
#  
# readfailist = open(failinimi, encoding = "UTF-8")
# read = []                                #ilma reavahetusteta ridade list
# for rida in readfailist:                 #reakaupa listist readfailist
#         read = read + [rida.strip("\n")] #ilma reavahetuseta rida lisatakse listi
#         # või read.append(rida.strip("\n"))
# readfailist.close() # faili ei lähe enam vaja
#  
# sisestatud_pin = ""
# katseid = 3
# while sisestatud_pin != "1234" and katseid > 0:
#     print(read[0])
#     print(read[1] + str(katseid) + read[2])
#     katseid -= 1
#     sisestatud_pin = input()
# if sisestatud_pin == "1234":
#     print(read[3])
# else:
#     print(read[4])
#     i = 10
#     while i > 0:
#         print(i)
#         i -= 1
#         sleep(1)
#         
#         
# readfailist = open("RV031sm.csv")
# aastad = []                              # järjend aastate jaoks
# iibed = []                               # järjend iivete jaoks
# for rida in readfailist:                 # reakaupa listist readfailist
#     realt = rida.split(';')              # jaotada semikooloni kohalt
#     aastad += [int(realt[0].strip('"'))] # aastate järjendisse juurde
#     # või aastad.append(int(realt[0].strip('"')))
#     iibed += [int(realt[1])]             # iivete järjendisse juurde
#     # või iibed.append(int(realt[1]))
# readfailist.close()                      # faili ei lähe enam vaja
# print(aastad)
# print(iibed)


# 
# 
# 
# fail = open("rebased.txt", encoding="UTF-8")
# 
# vastuvõetud = []
# 
# for rida in fail:
# 
#     vastuvõetud.append(int(rida))
# 
# fail.close()
# 
# print(vastuvõetud[4])
# aasta=int(input("Palun sisestage, millise aasta andmeid vajate: "))
# aastavahe1=int(2019)-aasta
# aastavahe2=int(0)+aasta
# if aasta == 2019:
#     print(aastavahe2 , ". aastal oli vastuvõetuid " , vastuvõetud[8])
# elif aasta == aastavahe2:
#     print(aastavahe2, ". aastal oli vastuvõetuid " ,vastuvõetud[8-(aastavahe1)])
          

# fail = open("konto.txt", encoding="UTF-8")
# konto = []
# for rida in fail:
#     konto.append(int(rida))
# i = 0
# while i > len(konto):
#     if konto[i] < 0:

#         konto[i] = 0
#     i += 1
# fail.close()
# 
# print(konto)
fail = open("konto.txt", encoding="UTF-8")
saldo = []
for rida in fail:
    saldo.append(float(rida))
fail.close()
i = 0
while i < len(saldo):
    if saldo[i] > 0:
#         saldo[i] = 0
        print(saldo[i])
    i += 1
#         return a()
# print(saldo)
