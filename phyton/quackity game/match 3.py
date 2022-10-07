#MATCH 3

from random import randint

def match_three():
    global punktid
    x=0
    x=randint(1,3)
    y=0
    y=randint(1,3)
    z=0
    z=randint(1,3)
    print("Tulemus on: ")
    print(str(x)+" "+str(y)+" "+str(z))
    if x==y==z:
        print("Kolm samasugust!")
        if x==y==z==1:
            print("Sul on nüüd "+str(punktid)+" punkti.")
        elif x==y==z==2:
            print("Sul on nüüd "+str(punktid+panus*2)+" punkti.")
            punktid=punktid+panus*2
        elif x==y==z==3:
            print("Sul on nüüd "+str(punktid+panus*3)+" punkti.")
            punktid=punktid+panus*3
    elif x==1 and y==2 and z==3:
        print("Rida")
        print("Sul on nüüd "+str(punktid+panus*2)+" punkti.")
        punktid=punktid+panus*2
    elif x==3 and y==2 and z==1:
        print("Rida")
        print("Sul on nüüd "+str(punktid+panus*2)+" punkti.")
        punktid=punktid+panus*2
    else:
        print("Ei midagi")
        punktid-=panus
    print("Sul on nüüd "+str(punktid)+" punkti.")
        
    
#-------------------------------#
punktid=10
valik="jah"
print('Tere tulemast "Match 3" mängu!')
print("Siin hakkavad tekkima 3 järjestikust numbrit.")
print("Kui oled panustanud mingi arvu punkte, tekkivad siia numbrid ning kui need numbrid on mingit moodi seotud saad sa panustatud punktid kasumiga tagasi.")
print("Kui numbrid lähevad järjest 1-st 3-ni või 3-st 1-ni antakse sulle punktid kahe kordselt tagasi.")
print("Kui kõik numbrid on samasugused, siis saad sa panustatud punktid tagasi nii mitme kordselt kui suured on need punktid")

while valik=="jah":
    panus=int(input("Palju sa panustad? "))
    if panus <= punktid:
        match_three()
    else:
        print("Sul ei ole nii palju punkte")
    valik=(input("Kas sa soovid veel mängida? (Jah või ei)"))
    if valik=="ei":
        print("haha")

