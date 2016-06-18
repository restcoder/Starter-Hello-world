import time
import sys
import os
from flask import Flask
from flask import jsonify
from threading import Thread

app = Flask(__name__)

@app.route('/hello')
def hello():
    return 'world'

@app.route('/hello-json')
def helloJson():
    return jsonify(hello='world')

class readyThread(Thread):
    def run(self):
        time.sleep(1)
        sys.stdout.write('READY')
        sys.stdout.flush()

if __name__ == "__main__":
    readyThread().start()
    app.run(host='0.0.0.0', port=int(os.getenv('PORT')))