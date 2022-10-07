# failinimi=input("Sisestage failinimi: ")
# 
# fail = open(failinimi, encoding="UTF-8")
# 
# for rida in fail:                      # ridade kaupa
#     for sümbol in rida:             # sümbolite kaupa
#         if sümbol == "":
#             break
#         elif sümbol == "ä" or sümbol == "Ä":
#             print("AE", end = "")
#         elif sümbol == "Ü" or sümbol == "ü":
#             print("UE", end = "")
#         elif sümbol == "õ" or sümbol == "Õ" or sümbol =="ö" or sümbol == "Ö":
#             print("OE", end = "")
#         else:
#             print(sümbol.upper(), end = "") # reavahetust ei tule

# while True:                     # lõpmatu tsükkel, kui ei katkestata
#     sümbol = fail.read(1)          # loetakse üks sümbol
#     if sümbol == "":            # kui enam sümboleid pole
#         break                   # tsükkel katkestatakse
#     if sümbol == "õ":
#         print("OE", end = "")    # reavahetust ei tule
#     if sümbol == "ü":
#         print("UE", end = "")
#     elif sümbol == "õ" or "Õ" or "ö" or "Ö":
#         print("OE", end = "")
#     elif sümbol == "ä" or "Ä":
#         print("AE", end = "")
#     else:
#         print(sümbol, end = "")
# print(sümbol.upper(), end = "")            
# fail.close()

#print()

# failisisu = fail.read()
#  
# asendatudõ = failisisu.replace("õ","OE")
# asendatudö = failisisu.replace("ö","OE")
# asendatudü = failisisu.replace("ü","UE")
# asendatudä = failisisu.replace("ä","AE")
#  
# print(failisisu)
#  
# fail.close()


# from datetime import datetime
# kuupäev = datetime.today()
# #print("Kuupäev ja kellaeg: " + str(kuupäev))
# 
# 
# tekst = input("Sisesta sissekande tekst: ")
# 
#  
# f = open("paevik.txt", "a", encoding="UTF-8")
# f.write(str(kuupäev) + "\n")
# f.write(tekst + "\n")
# f.write("" + "\n")
# f.close()




