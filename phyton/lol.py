# 1. rida 4
# 2. rida 22
# 3. rida 170
# 4. rida 



# a = (input("Sisestage astme alus: "))
# b = (input("Sisestage astendaja: "))
# print(type(a))
# c = int(a) ** int(b)
# print(c)
# 
# a = input("Sisestage ainepunktide arv: ")
# b = input("Sisestage nädalate arv: ")
# c = (int(a) * 26)/ int(b)
# print(round(c))
# 
# nimi = (input("Sisestage oma nimi: "))
# lkiirus =(input("Sisestage lubatud kiirus (km/h): "))
# tkiirus = (input("Sisestage tegelik kiirus (km/h): "))
# vahe = int(tkiirus) - int(lkiirus)
# trahv = int(vahe) * 3
# a = min(190, trahv)
# b = nimi + ", kiiruse ületamise eest on teie trahv " + str(a) + " eurot"
# print(b)
# 
# inp = (input("Palun sisesta pilvede kõrgus: "))
# k = float(inp)
# if k > 6:
#      print("Need on ülemised pilved")
# else:
#      print("Need ei ole ülemised pilved")
# 
# kasutajanimi= input()
# sisestatud_pin= input()
# if kasutajanimi.lower() "siil" and sisestatud_pin == "1234":
#     print("Tere")
#     kontoseis = 100
#     print ("Kontol on ", kontoseis, "eurot")
#     soovitud_raha = int(input())
#     if kontoseis >= soovitud_raha:
#         kontoseis = kontoseis - soovitud_raha
#         #kontoseis -= soovitud_raha
#         print("Võtke raha")
#     else:
#         print("Pole piisavalt raha")
#     print("Kontol on nüüd" + str(kontoseis) + " eurot.")
# else:
#     print("Vale")
#      
# kasSajab = True
# onRatas = True
# temp = int(input("Temp plz"))
# if onRatas and (not kasSajab or (25 > temp and temp > 15)):
#     print("saab")
# else:
#     print("ei saa")
# 
# from random import randint
#  
# print("Kas kull (1) või kiri (2)?")
# kasutaja_valik = int(input())
# suvaline_arv = randint(1, 2)
#  
# if kasutaja_valik == suvaline_arv:
#     print("Arvasid õigesti.")
#     suvaline_arv2 = randint(1, 2)
#     if kasutaja_valik == suvaline_arv2:
#         print("Arvamus oli õige ka teisel korral.")
#     else:
#         print("Teist korda see arvamus enam õige ei olnud.")       
# else:
#     print("Arvasid valesti.")
# 
# punkt = (input("Palun sisesta punktisumma: "))
# p = float(punkt)
# if 0 <= p < 66:
#     print("Vähem kui kandideerimiseks vajalik")
# elif 66 <= p < 85:
#     print("Kandideerimine vastuvõtule")
# elif 85 <= p <= 100:
#     print("Vastuvõtt tagatud")
# else:
#     print("Vigane punktisumma")
# 
# vanus=(input("Sisestage enda vanus: "))
# sugu=(input("Sisestage enda sugu: "))
# tuup=(input("Sisestage treeningu tüüp: "))
# #print(type(tuup))
# v = int(vanus)
# t = int(tuup)
# #print(type(v))
# if sugu == ("m"):
#     #print("Mees")
#     maxpulss = 220 - v
# elif sugu == ("n"):
#     #print("Naine")
#     maxpulss = 206 - (v*0.88)
# elif sugu == ("N"):
#     #print("Naine")
#     maxpulss = 206 - (v*0.88)
# elif sugu == ("M"):
#     #print("Naine")
#     maxpulss = 220 - v
# else:
#     print("fuk u")
# if t == 1:
#     vpulss = round(maxpulss*0.5)
#     spulss = round(maxpulss*0.7)
#     b="Pulsisagedus peaks olema vahemikus " + str(vpulss) + " kuni " + str(spulss)
#     print(b)
# elif t == 2:
#     vpulss = round(maxpulss*0.7)
#     spulss = round(maxpulss*0.8)
#     b="Pulsisagedus peaks olema vahemikus " + str(vpulss) + " kuni " + str(spulss)
#     print(b)
# elif t == 3:
#     vpulss = round(maxpulss*0.8)
#     spulss = round(maxpulss*0.87)
#     b="Pulsisagedus peaks olema vahemikus " + str(vpulss) + " kuni " + str(spulss)
#     print(b)
# else:
#     print("fuk u")
#
# from random import randint
# küs1 = input("Kas soovite istekohta ise valida ('ise') või loosida ('loos')? ")
# k1 = str(küs1)
# if k1 == "ise":
#     küs2 = input("Kas soovite istuda akna ääres ('aken') või mitte ('muu')? ")
#     k2 = str(küs2)
#     if k2 == "aken":
#         print("Valisite ise. Aknakoht")
#     elif k2 == "muu":
#         print("Valisite ise. Vahekäigukoht")
#     else:
#         print("fuk u")
# elif k1 == "loos":
#     iste = randint(1, 3)
#     i = str(iste)
#     if i == 1:
#         print("Istekoht loositi. Aknakoht")
#     else:
#         print("Istekoht loositi. Vahekäigukoht")
# 
# inimesed = input("Inimeste arv: ")
# kohad = input("Kohtade arv: ")
# i = int(inimesed)
# k= int(kohad)
# bussid = i//k 
# ülejääk = i % k
# ü = str(ülejääk)
# if ülejääk > 0:
#     bussid += 1
# else:
#     bussid += 0
# b = str(bussid)
# print("Busse vaja: " + b)
# if ülejääk > 0:
#     print("Viimases bussis inimesi: " + ü)
# else:
#     print ("Viimases bussis inimesi: " + kohad)
# 
# suurus = input("Sisestage kirja suurus: ")
# pealkiri = input("Sisestage kirja teema pealkiri: ")
# fail = input("Kas kirjaga on kaasas fail? ")
# s = float(suurus)
# p = str(pealkiri)
# f = str(fail)
# if (f == "jah" and s > 1) or p == "":
#     print("Kiri on spämm")
# else:
#     print("Kiri ei ole spämm")
#
# s = int(input("täisarv: "))
# if s < 5:
#     if s == 0:
#         print("1")
#     else:
#         print("2")
# else:
#     if s < 10:
#         print("3")
# a = 3
# if a > 0:
#     print("pos")
# if a != 5:
#     print("pole 5")
# if a == 3:
#     print("a on 3")
# if a%2 == 0:
#     print("paaris")
# else:
#     print("paaritu")
# 
# küsimus=input("Sisestage mitu korda ärgata: ")
# küs = float(küsimus)
# i=0
# while i < küs:
#     print("Tõuse ja sära!")
#     i=i+1
# 
# küsimus=input("Sisesta ringide arv: ")
# küs=float(küsimus)
# i=2
# summa=2
# s=2  
# while küs < i:
#     i=i+2+summa
#     summa=2+summa
#     s=2+summa+s
# istr=str(i)
# print("Porgandite koguarv on "+istr)
# 
# küs=input("Sisesta ringide arv: ")
# valitudarv=float(küs)
# i=0  #RINGIDE ARV
# mingiarv=2
# summa=0  #MIDA NÄIDATAKSE
# while valitudarv > mingiarv:
#     i=i+2
#     summa=summa+2+i
# summastr=str(summa)
# 
# print("Porgandite koguarv on "+ summastr)
    
# 
# from random import randint
# täringud=input("Täringute arv: ")
# t=int(täringud)
# fo=0
# f=float(fo)
# 
# while f < t:
#     f=f+1
#     arv=str(randint(1,6))
#     print(arv)

# from random import randint
# õun = 14
# õ=float(õun)
# mitu=input("Mitu pöialpoissi tahab õunu? ")
# m=float(mitu)
# kokku=0
# k=float(kokku)
# 
# while õ<m:                         #kuidagi nii et see lihtsalt korrutab m
#     arv=int(randint(1,2))
#     print(arv)
#     a=float(arv)
#     õ=õ-a      
# if õ > 0:
#     õu=int(õ)
#     print("Lumivalgekesele jäi "+str(õu))
#     else:
#         print("njet")
        
# from random import randint
# pöialpoisse = int(input("Mitu pöialpoissi tahab õunu?: "))
# õunu = 14
# while pöialpoisse>0:
#     mitu=randint(1,2)
#     print(mitu)
#     õunu=õunu-mitu
#     pöialpoisse -= 1
# print("Lumivalgekesele jäi",õunu)

# # 
# from random import randint
# i = 1
# while i < 6:
#     print("Täringu " + str(i) + ". viskel saadi " + str(randint(1, 6)) + ".")
#     i += 1
# 
# mitmes_ruut=input("Sisestage täisarv: ")
# mit=int(mitmes_ruut)
# maks = 1
# kokku=1
# while mit>maks:
#     maks = maks*2
#     print(maks)
#     kokku = kokku *maks
#     print(kokku)
# print("Nisuteri "+str(mit)+". ruudu eest: "+str(kokku))

# laud=64
# kokku=0
# ruudunr=int(input("Sisestage täisarv: "))
# if ruudunr>0:
#     kokku=1
# kord=1
# while ruudunr>kord:
#     kord+=1
#     kokku =kokku*2
# #     ruudunr -=1
# print("Nisuteri "+ str(ruudunr)+". ruudu eest: ",kokku)


# from tkinter import *
# raam=Tk()
# raam.title("Tühi tahvel")
# 
#  #värv
# tahvel=Canvas(raam,width=600,background="red",height=400)
#  # üks horisontaalne sirglõik
# tahvel.create_line(50,50,100,50)
#  # horisontaalne sirglõik ja vertikaalne sirglõik
# tahvel.create_line(50,150,100,150,100,200)
#  # sirglõik paksusega 4px
# tahvel.create_line(50,100,100,250, width=4)
#  # rohelist värvi nool paksusega 4px
# tahvel.create_line(350,50,350,100, width=4, fill="green", arrow=LAST)
#  # ruut
# tahvel.create_line(150,150,200,150,200,200,150,200,150,150,fill="white")
#  # roheliste servadega punane ovaal(ring)
# tahvel.create_oval(10,10,100,100, fill="red", outline="green")
#  # musta värvi tekst "Tere!"
# tahvel.create_text(50,50, text="Tere!")
#  # sinist värvi teksti "Tere!" alumine vasak punkt on (50, 50)
# tahvel.create_text(50,50, text="Tere!", anchor=SW, fill="blue")
# 
# 
# tahvel.pack()
# 
# raam.mainloop()


# # impordi tk vidinad ja konstandid
# from tkinter import *            # tkinteri põhivahendid
# from tkinter import ttk          # platvormi ühise stiili saamiseks
# from tkinter import messagebox
#  
# # see funktsioon käivitatakse nupule klõpsamisel
# def tervita():
#     tervitus = 'Tere, ' + nimi.get()
#     messagebox.showinfo(message=tervitus)
#  
#  
# # loome akna
# raam = Tk()
# raam.title("Tervitaja")
# raam.geometry("300x100")
#  
# # loome tekstikasti jaoks sildi
# silt = ttk.Label(raam, text="Nimi")
# silt.place(x=5, y=5)
#  
# # loome tekstikasti
# nimi = ttk.Entry(raam)
# nimi.place(x=70, y=5, width=150)
#  
# # loome nupu
# nupp = ttk.Button(raam, text="Tervita!", command=tervita)
# nupp.place(x=70, y=40, width=150)
#  
# # ilmutame akna ekraanile
# raam.mainloop()


from tkinter import *
 
raam = Tk()
raam.title("Lipp")
tahvel = Canvas(raam, width=600, height = 300)
kõrgus = 100
i = 0
while i < 3:
#     if i == 0 or i == 1 or i == 2:
#     if i % 2 == 0:
    tahvel.create_rectangle(0, i * kõrgus, 200, (i + 1) * kõrgus, fill="green", outline="green")
    tahvel.create_rectangle(200, i * kõrgus, 400, (i + 1) * kõrgus, fill="white", outline="white")
    tahvel.create_rectangle(400, i * kõrgus, 600, (i + 1) * kõrgus, fill="blue", outline="blue")
    #tahvel.create_rectangle(200, i * kõrgus, 600, (i + 1) * kõrgus, fill="white", outline="white")

#     else:
#         # valge väike ristkülik
#         tahvel.create_rectangle(0, i * kõrgus, 200, (i + 1) * kõrgus, fill="white", outline="green")
    
    i += 1

tahvel.pack()

raam.mainloop()


# from tkinter import*
# raam=Tk()
# raam.title("Liiklusmärk")
# tahvel=Canvas(raam,width=600,background="white",height=400)
# #sirglõik paksusega 4px
# tahvel.create_line(20,120,600,480, width=25, fill="red")
# tahvel.create_line(20,480,600,120, width=25, fill="red")
# tahvel.create_line(0,280,600,-80, width=25, fill="red")
# tahvel.create_line(120,0,600,300, width=25, fill="red")
# tahvel.create_line(170,120,600,480, width=50, fill="white")
# 
# 
# tahvel.pack()
# raam.mainloop()

# from tkinter import*
# raam=Tk()
# raam.title("Maja")
# tahvel=Canvas(raam,width=600,background="light blue",height=600)
# tahvel.create_rectangle(150,200,500,500, width=15,fill="yellow")
# tahvel.create_polygon(150,200,500,200,320,40,width=15, fill="red",outline="black")
# tahvel.create_rectangle(350,400,300,500, width=15,fill="brown")
# tahvel.create_rectangle(200,300,300,400, width=15,fill="light blue")
# tahvel.create_rectangle(350,300,450,400, width=15,fill="light blue")
# 
# tahvel.pack()
# raam.mainloop()

