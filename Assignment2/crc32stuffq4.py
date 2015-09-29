import binascii, random, string, time

def randomword(length):
   return ''.join(random.choice(string.lowercase) for i in range(length))

start = time.time()
x = "b5203ab077fac4fba801f85325896b2b"
crcx = binascii.crc32(x)
y = randomword(32)
crcy = binascii.crc32(y)
count = 0

while True:
    count+=1
    if count % 1000000 == 0:
        print count
        print time.time()
    y = randomword(32)
    if x != y:
        crcy = binascii.crc32(y)
        if crcy == crcx:
            break
        
print "x: " + str(x)
print "crcx: " + str(crcx)
print "y: " + str(y)
print "crcy: " + str(crcy)
end = time.time()

print "time: " + str(end - start)