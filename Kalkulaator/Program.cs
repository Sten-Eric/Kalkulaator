esimene = int(input("Esimene arv: "))
teine = int(input("Teine arv: "))
kolmas = input("Kas (Korruta,Jaga,Liida,Lahuta): ")

if kolmas == "Korruta":
    print(esimene * teine)
if kolmas == "Jaga":
    print(esimene / teine)
if kolmas == "Liida":
    print(esimene + teine)
if kolmas == "Lahuta":
    print(esimene - teine)