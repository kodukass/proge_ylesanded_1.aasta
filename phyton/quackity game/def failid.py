from random import randint

def pesa_mäng():
    number=0
    panus=(int(input("Palju sa panustad, et programm jääb seisma number 3 peale 4'st? (Sisesta täisarv) ")))
    if panus > punktid:
        print("Sul ei ole nii palju punkte.")
    elif panus <= punktid:
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
print("Tere tulemast Pesa mängu!")
print("Siin mängus pead sa pakkuma, mis numbri peal jääb programm seisma.")
print("Pakkumisi peab tegema punktide peale.")
print("Kui sa võidad, siis sinu pakutud punktid korrutatakse kahega.")
print("Sul on praegu "+str(punktid)+ " punkti.")
pesa_mäng()
küs=(input("Kas sa soovid veel mängida? Jah või Ei"))
if küs == "jah":
    küs1 +=1
elif küs == "ei":
    küs1==0
    
while punktid >= 0 and küs1>=1:
    pesa_mäng()
    
if punktid == 0 or küs1==0:
    #start()