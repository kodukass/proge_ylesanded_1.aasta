#PESAMÄNG

from random import randint

def pesa_mäng():
    global punktid
    number=0
    number=randint(1,4)
    print("Programm jäi seisma "+str(number)+" peale!")
    if number == 3:
        print("Palju õnne! Sul on nüüd "+str(punktid+panus)+" punkti!")
        punktid += panus
    else:
        print("Kahjuks oli number "+str(number)+ ", mitte 3.")
        print("Nüüd on sul "+str(punktid-panus)+" punkti.")
        punktid -= panus
        
#----------
punktid=10
küs1=0
mänguvalik1="jah"
print("Tere tulemast Pesa mängu!")
print("Siin mängus pead sa pakkuma, mis numbri peal jääb programm seisma.")
print("Pakkumisi peab tegema punktide peale.")
print("Kui sa võidad, siis sinu pakutud punktid korrutatakse kahega.")
print("Sul on praegu "+str(punktid)+ " punkti.")

while mänguvalik1=="jah":
    panus=int(input("Palju sa panustad? "))
    if panus <= punktid:
        pesa_mäng()
    else:
        print("Sul ei ole nii palju punkte")
    mänguvalik1=(input("Kas sa soovid veel mängida? (Jah või ei) "))
    if mänguvalik1=="ei":
        print("haha")