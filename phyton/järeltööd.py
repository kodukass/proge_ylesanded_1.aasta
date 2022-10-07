from tkinter import *
raam = Tk()
raam.title("Malelaud")
# loome tahvli laiusega 600px
tahvel = Canvas(raam, width=100, height=100)
# paigutame tahvli raami ja teeme nähtavaks
tahvel.pack()
i = 10
while i <= 90:
    j = 0
    while j <= 90:
        #print("i = " + str(i) + ", j = " + str(j))
        tahvel.create_rectangle(i,j,100,100)
        j += 10
    i += 10

# siseneme põhitsüklisse
raam.mainloop()

# i = 10
# while i <= 80:
#     j = 0
#     while j <= 80:
#         print("i = " + str(i) + ", j = " + str(j))
#         j += 10
#     i += 10