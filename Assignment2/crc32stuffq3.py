import binascii, random, string, time

def randomword(length):
   return ''.join(random.choice(string.lowercase) for i in range(length))

start = time.time()
x = randomword(32)
crcx = binascii.crc32(x)
dictx = { crcx : x }
y = randomword(32)
crcy = binascii.crc32(y)
dicty = { crcy : y }
count = 0

while True:
    y = randomword(32)
    x = randomword(32)
    crcy = binascii.crc32(y)
    crcx = binascii.crc32(x)
    if crcx in dicty:
        if x != dicty[crcx]:
            print "x: " + str(x)
            print "crc32: " + str(crcx)
            print "y: " + str(dicty[crcx])
            break
    else:
        dictx[crcx] = x
    if crcy in dictx:
        if y != dictx[crcy]:
            print "y: " + str(y)
            print "crc32: " + str(crcy)
            print "x: " + str(dictx[crcy])
            break
    else:
        dicty[crcy] = y

end = time.time()

print "time: " + str(end - start)