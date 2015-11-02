import hashlib
import sys

passReplace = hashlib.sha1(sys.argv[1]).digest()
with open("37597119.program2.exe", "r+b") as f:
  pos = f.read().find("\x0D\x50\x93\x9C\x90\x10\xFD\x6D\xFD\x11\x74\x43\xBB\x46\xC3\x14\x90\x6D\x56\xF0")
  f.seek(pos)
  f.write(passReplace)