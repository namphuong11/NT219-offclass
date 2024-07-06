import hashlib
import hmac

def generate_hmac_sha1(key, message):
    return hmac.new(key, message, hashlib.sha1).hexdigest()

def generate_hmac_sha256(key, message):
    return hmac.new(key, message, hashlib.sha256).hexdigest()


def generate_hmac_sha512(key, message):
    return hmac.new(key, message, hashlib.sha512).hexdigest()

# Ví dụ sử dụng
key = b'mainguyennamphuong22521164'
message = b'lab4-4-offclass'
hmac_digest = generate_hmac_sha512(key, message)
print(f'HMAC-SHA: {hmac_digest}')
