# porgandeid=0
# metsaringe=int(input("Sisesta ringide arv"))
# while metsaringe>0:
#     if metsaringe%2 ==0:
#         porgandeid+=metsaringe
#     metsaringe-=1
# print("Porgandite koguarv on ",porgandeid)

porgandeid=0
metsaringe=int(input("Sisesta ringide arv"))
for i in range(metsaringe+1):
    if i%2 ==0:
        porgandeid+=i
    
print("Porgandite koguarv on ",porgandeid)
