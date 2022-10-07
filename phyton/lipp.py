#failinimi=input("Sisesta failinimi: ")
# f = open(failinimi, encoding='UTF-8')
#  
# tõde = 0   # loendaja
# õigus = 0  # loendaja
# kokku=0
#  
# for rida in f:           # ridade kaupa
#     sõnad = rida.split() # rea sõnad järjendisse
#     for s in sõnad:      # sõnade kaupa
#         if s == "?":
#             tõde += 1
#         if s == "+":
#             õigus += 1
#             
# kokku=kokku+tõde+õigus
#  
# f.close()
# def eelarve(inimeste_arv):
#     return round(int(inimeste_arv)*10+55)
# 
# print("Kutsutud on "+str(kokku)+" inimest")
# print(int(õigus),"inimesi tuleb")
# print("Maksimaalne eelarve: "+str((eelarve(kokku))))
# print("Minimaalne eelarve: "+str((eelarve(õigus))))


# kuu=input("Sisesta kuu: ")
# päev=input("Sisesta päev: ")
# from urllib.request import urlopen
#  
# failVeebis = urlopen("http://kodu.ut.ee/~eno/mooc/"+str(kuu))
# baidid = failVeebis.read()  # kogu fail baitidena
# tekst = baidid.decode()     # baitidest saab sõne
# ridadeKaupa = tekst.splitlines()   # sõne jaotatakse reavahetuse kohtadelt
# failVeebis.close()
# print(ridadeKaupa[int(päev)-1])           # rida indeksiga 4
# print(ridadeKaupa[4][7])
# print(tekst)
#"Kuupäeval", str(päev),".",str(kuu), "on nimepäevad järgmiste nimedega inimestel: ",



# #argument s on sõne, esialgu see on kuupäev, edasi juba arvutatud arv
def elutee(s):
    #abimuutaja numbri arvutamiseks
    n = 0
    # tsükkel, mis vaatab iga sümboli sõnes
    for i in s:
        if i != ".":
            n += int(i) # arvutame summat
    # kui saadud arv on väiksem kui 10, siis ongi elutee number käes
    if n < 10:
        return n
    # kui saadud arv on 10 või suurem, siis on vaja uuesti arvutada,
    #selleks kasutame jälle sama funktsiooni
    else:
        return elutee(str(n))

kuupäev=open("sunnikuupaevad.txt",encoding="UTF-8").read().splitlines()
for i in range(1,10):
    open("eluteenumber"+str(i)+".txt","w").close()
    
for kuup in kuupäev:
    number=elutee(kuup)
    fail=open("eluteenumber"+str(number)+".txt","a")
    fail.write(kuup+"\n")
    fail.close()