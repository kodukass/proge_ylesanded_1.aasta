#KAARDIMÄNG#
def kaardimäng():
    global punktid
    kaardid=[0,6,3,2,8,5,1,10,4,9,7]
    kaardinumber=[]
    miskaart=input("Mitmenda kaardi sa valid?")
    misnumber=input("Millise numbriga see on?")
    i=int(misnumber)
    j=int(miskaart)
    while i<len(kaardid):
        kaardinumber.append(misnumber)
        print(str(j)+". kaardi number on "+str(kaardid[j]))
        if kaardid[j] ==i:
            print("Tubli laps")
            punktid+=panus3
        else:
            print("Sa pakkusid vale numbri.")
            punktid-=panus3
        print("Sul on nüüd "+str(punktid)+" punkti.")
        return

punktid=10
print("")
print("Tere tulemast Kaardimängu!")
print("Siin mängus pead sa arvama, milline kaart on mis numbriga.")
print("Mängus on 10 kaarti.")
print("Sul on praegu "+str(punktid)+" punkti.")
panus3=int(input("Palju sa panustad?"))
if panus3 <= punktid:
    kaardimäng()
else:
    print("Sul ei ole nii palju punkte")
