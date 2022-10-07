küs=input("Sisesta ringide arv: ")
valitudarv=float(küs)  #RINGIDE ARV
i=0  #RINGIDE ARV
mingiarv=2
summa=0  #MIDA NÄIDATAKSE
while valitudarv > mingiarv:
    i=i+2
    summa=summa+2+i
    valitudarv -= 1
    
summastr=str(summa)
print("Porgandite koguarv on "+ summastr)

# nimi=input("Sisestage oma ees-ja perekonnanimi: ")
# print((nimi).title())