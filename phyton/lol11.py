def juurdekasv(pindala,juurdekasvunr):
    i = 0
    j=0
    while i < len(pindala):
            vastus = round((((pindala[i])) * 0.4047)*float(juurdekasvunr),2)
            #print(vastus)
            if vastus>piir:
                print(vastus)
                i+=1
                j+=1
            else:
                print("Metsatükki ei võeta arvesse")
                i += 1
    print("arvutati "+str(j)+" juurdekasvu")        
    #vastus = ((int(pindala)) * 0.4047 * (int(juurdekasv)))
    #numbrid.append(vastus)
    #print(numbrid)

failinimi=input("failinimi pindaladega plz")
juurde=(input("juurdekasv plz"))
piir=float(input("piir"))
fail = open(failinimi, encoding="UTF-8")
pindalad = []
for rida in fail:
    pindalad += [float(rida)]     
fail.close()
juurdekasv(pindalad,juurde)

    