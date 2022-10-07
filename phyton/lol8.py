# def funktsioon(f):
#     print(f)
#     
# mitmes = 0
# d="Kui Arno isaga koolimajja jõudis, olid tunnid juba alanud."
# while mitmes < 4:
#     mitmes += 1
#     funktsioon(d)
    


# def funktsioon(linn):
#     print("Üks Euroopa pealinnadest on "+linn+".")
#     
# pealinnad=["Tallinn","Riia","Helisngi","Stockholm"]
# 
# for linn in pealinnad:
#     funktsioon(linn)



# from random import randint
# def funktsioon(tärnid,sümbol):
#     print(str(tärnid)+(sümbol*tärnid))
#     
# for i in range(20,40):
#     tärnid=randint(1,20)
#     funktsioon(tärnid,chr(randint(32,126)))
    
    
    
# loomad=["koer", "kass", "jänes", "sipelgasiil", "lendorav"]
# 
# def funktsioon(loomad):
#     return len(loomad)
#     
# for loom in loomad:
#     pikkus=funktsioon(loom)
#     pikimloom= max(loomad,key=len)
#     pikimloom=""
#     if pikkus>funktsioon(pikimloom):
#         pikimloom=loom
# print(pikimloom)



from urllib.request import urlopen
 
failVeebis = urlopen("https://courses.cs.ut.ee/2018/eprogalused/uploads/Main/mesipuu.txt")
baidid = failVeebis.read()  # kogu fail baitidena
tekst = baidid.decode()# baitidest saab sõne
ridadeKaupa = tekst.splitlines()   # sõne jaotatakse reavahetuse kohtadelt
failVeebis.close()
print(ridadeKaupa[4])              # rida indeksiga 4
print(ridadeKaupa[4][7])              # rida indeksiga


# from urllib.request import urlopen
# failVeebis = urlopen("http://www.cs.ut.ee")
# baidid = failVeebis.read(121)  # 121 esimest
# tekst = baidid.decode()        # baitidest saab sõne
# print(tekst)
# failVeebis.close()


# from webbrowser import *
# open("www.cs.ut.ee")


# from webbrowser import *
# sona = input("Sisestage sõna: ")
# aadress = "http://www.eki.ee/dict/qs/index.cgi?Q=" + sona
# open(aadress)



# from urllib.request import urlopen
#  
# failVeebis = urlopen("https://courses.cs.ut.ee/2018/eprogalused/uploads/Main/mesipuu.txt")
# baidid = failVeebis.read()  # kogu fail baitidena
# tekst = baidid.decode()# baitidest saab sõne
# ridadeKaupa = tekst.splitlines()
#  
# tõde = 0   # loendaja
# õigus = 0  # loendaja
#  
# for rida in f:           # ridade kaupa
#     sõnad = rida.split() # rea sõnad järjendisse
#     for s in sõnad:      # sõnade kaupa
#         if s == "tõde":
#             tõde += 1
#         if s == "õigus":
#             õigus += 1
#  
# print("Failis sõna 'tõde' on", tõde,  "korda.")
# print("Failis sõna 'õigus' on", õigus, "korda.")
#  
# f.close()



# nimi = input("Palun sisesta oma nimi: ")
# vanus = input("vanus: ")
# aadress = input("aadress: ")
#  
# f = open("andmed3.txt", "w")
# f.write(nimi + "\n")
# f.write(vanus + "\n")
# f.write(aadress + "\n")
# f.close()


# doonorNimi = input("Mis failist info võtta? ")
# aktseptorNimi = input("Millisesse faili info pannakse? ")
# doonorFail = open(doonorNimi, encoding="UTF-8")
# aktseptorFail = open(aktseptorNimi, "w")
# for rida in doonorFail:
#     aktseptorFail.write(rida.upper())
# doonorFail.close()
# aktseptorFail.close()


# print(ord("A"))
# print(ord("a"))
# print(ord("ä"))
# print(ord("õ"))
# print(ord(" "))


def kodeeri(sümbol, nihe):
     return chr(ord(sümbol) + nihe)
 
def šifreeri(failinimi, nihe):
    f = open(failinimi, "w")
    kiri = input("Sisesta lause ")
    for sümbol in kiri:
        f.write(kodeeri(sümbol, nihe))
    f.close()
 
failinimi = input("Faili nimi? ")
nihe = int(input("Nihe? "))
šifreeri(failinimi, nihe)