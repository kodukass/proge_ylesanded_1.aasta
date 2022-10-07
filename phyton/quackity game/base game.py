# QUACKITY LAS NEVADAS'E MÄNGUD :D

from random import randint
punktid=10
def start():
    #mängu algus
    print("")
    print("Tere tulemast Las Nevadasesse!")
    if punktid ==0:                                  #kui punktid on otsas saab mäng läbi
        print("Sul on saanud punktid otsa!")
        print("Mäng läbi!")
        print("Tänan mängimast! :]")
    else:
        print("Siin saab mängida palju erinevaid mänge ning koguda ja kaotada punkte.")
        print("Kui sul saavad punktid otsa on mäng läbi.")                                   #mängu seletus
        print("Praegu on sul "+str(punktid)+" punkti. Millist mängu sa soovid mängida?")
    
def match_three(panus):
    global punktid
    x=0
    x=randint(1,3)
    y=0                           #tekitatakse 3 suvalist numbrit 1-3
    y=randint(1,3)
    z=0
    z=randint(1,3)
    print("Tulemus on: ")
    print(str(x)+" "+str(y)+" "+str(z))
    if x==y==z:
        print("Kolm samasugust!")
        #kirjutab ühe võidu#
        if x==y==z==1:
            print("Sul on nüüd "+str(punktid)+" punkti.")
        elif x==y==z==2:
            print("Sul on nüüd "+str(punktid+panus*2)+" punkti.")       #kui on mõni sarnasus saadakse punkte juurde
            punktid=punktid+panus*2
        elif x==y==z==3:
            print("Sul on nüüd "+str(punktid+panus*3)+" punkti.")
            punktid=punktid+panus*3
    elif x==1 and y==2 and z==3:
        print("Rida")
        print("Sul on nüüd "+str(punktid+panus*2)+" punkti.")
        punktid=punktid+panus*2
        #kirjutab ühe võidu#
    elif x==3 and y==2 and z==1:
        print("Rida")
        print("Sul on nüüd "+str(punktid+panus*2)+" punkti.")
        punktid=punktid+panus*2
        #kirjutab ühe võidu#
    else:
        print("Ei midagi")                                           #kui sarnasusi pole ei saa punkte tagasi
        punktid-=panus
    print("Sul on nüüd "+str(punktid)+" punkti.")
        
def pesa_mäng(panus):
    global punktid
    number=0
    number=randint(1,4)                                                   #tekitatakse suvaline number 1-4
    print("Programm jäi seisma "+str(number)+" peale!")
    if number == 3:
        print("Palju õnne! Sul on nüüd "+str(punktid+panus)+" punkti!")    #kui number on 3 siis saadakse punkte
        punktid += panus
        #kirjutab ühe võidu#
    else:
        print("Kahjuks oli number "+str(number)+ ", mitte 3.")              #kui ei siis võetakse punkte vähemaks
        print("Nüüd on sul "+str(punktid-panus)+" punkti.")
        punktid -= panus
        
        
def kaardimäng(panus):
    global punktid
    kaardid=[0,6,3,2,8,5,1,10,4,9,7]                                #järjekord kaardidest
    kaardinumber=[]
    miskaart=input("Mitmenda kaardi sa valid?")                  #peab valima mingi kaardi
    misnumber=input("Millise numbriga see on?")                   #ja arvama ära mis number sel kaardil on
    i=int(misnumber)
    j=int(miskaart)
    while i<len(kaardid):
        kaardinumber.append(misnumber)
        print(str(j)+". kaardi number on "+str(kaardid[j]))
        if kaardid[j] ==i:
            print("Tubli laps")                                  #kui öeldakse õige number saadakse punkte
            punktid+=panus
        else:
            print("Sa pakkusid vale numbri.")
            punktid-=panus
        print("Sul on nüüd "+str(punktid)+" punkti.")            #kui ei siis võetakse punkte vähemaks
        return

def mänguvalik():
    valik=0
    mänguvalik1="jah"
    mänguvalik2="jah"
    mänguvalik3="jah"
    start()
    valik=(input("Valikus on: '1.Pesa mäng'; '2.Match 3'; '3.Kaardimäng' (Kirjutage mängu järjekorra number) "))
    if valik == "1":
        print("")
        print("Tere tulemast Pesa mängu!")
        print("Siin mängus pead sa pakkuma, mis numbri peal jääb programm seisma.")
        print("Pakkumisi peab tegema punktide peale.")
        print("Kui sa võidad, siis sinu pakutud punktid korrutatakse kahega.")
        print("Sul on praegu "+str(punktid)+ " punkti.")                            #mängu kirjeldus kasutajale

        while mänguvalik1=="jah":
            panus=int(input("Palju sa panustad? "))
            if panus <= punktid:
                pesa_mäng(panus)
            else:
                print("Sul ei ole nii palju punkte")
            mänguvalik1=(input("Kas sa soovid veel mängida? (Jah või ei) "))
            if mänguvalik1=="ei":
                start()
            
    elif valik == "2":
        print("")
        print('Tere tulemast "Match 3" mängu!')
        print("Siin hakkavad tekkima 3 järjestikust numbrit.")
        print("Kui oled panustanud mingi arvu punkte, tekkivad siia numbrid ning kui need numbrid on mingit moodi seotud saad sa panustatud punktid kasumiga tagasi.")
        print("Kui numbrid lähevad järjest 1-st 3-ni või 3-st 1-ni antakse sulle punktid kahe kordselt tagasi.")
        print("Kui kõik numbrid on samasugused, siis saad sa panustatud punktid tagasi nii mitme kordselt" )
        print("kui suured on need punktid.")       #mängu kirjeldus kasutajale

        while mänguvalik2=="jah":
            panus=int(input("Palju sa panustad? "))
            if panus <= punktid:
                match_three(panus)
            else:
                print("Sul ei ole nii palju punkte")
            mänguvalik2=(input("Kas sa soovid veel mängida? (Jah või ei)"))
            if mänguvalik2=="ei":
                start()

    elif valik == "3":
        print("")
        print("Tere tulemast Kaardimängu!")
        print("Siin mängus pead sa arvama, milline kaart on mis numbriga.")
        print("Mängus on 10 kaarti.")
        print("Sul on praegu "+str(punktid)+" punkti.")        #mängu kirjeldus kasutajale
        while mänguvalik3=="jah":
            panus=int(input("Palju sa panustad? "))
            if panus <= punktid:
                kaardimäng(panus)
            else:
                print("Sul ei ole nii palju punkte")
            mänguvalik3=(input("Kas sa soovid veel mängida? (Jah või ei)"))
            if mänguvalik3=="ei":
                start()
                
while True:
    mänguvalik()       #mäng töötab nii kaua kuni on punkte
