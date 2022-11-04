from flask import Flask, render_template, request, redirect, session

app = Flask(__name__)
app.secret_key = 'keep it secret, keep it safe'

from user_model import User


@app.route('/') 
def homepage():
    all_users = User.get_all()
    return render_template('read_all.html', all_users = all_users)

@app.route('/users/new')
def new():
    return render_template('create.html')

@app.route('/users/create', methods = ['POST'])
def create_user():
    User.create(request.form)
    return redirect('/')

@app.route('/users/<int:id>/edit')
def edit_user(id):
    return render_template("edit.html",user=User.get_one({'id':id}))

@app.route('/users/<int:id>/update',methods=['POST'])
def update(id):
    data = {
        **request.form,
        'id' : id
    }
    User.update(data)
    return redirect('/')

@app.route('/users/<int:id>/show')
def show(id):
    return render_template("show_user.html",user=User.get_one({'id':id}))

@app.route('/users/<int:id>/destroy')
def delete_user(id):
    User.delete({"id" : id})
    return redirect('/')



if __name__=="__main__": 
    app.run(debug=True) 