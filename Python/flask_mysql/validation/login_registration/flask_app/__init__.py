from flask import Flask
app = Flask(__name__)
app.secret_key = "shhhhhh"
DATABASE  = 'login_reg_schema'