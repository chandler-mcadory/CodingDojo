from flask import Flask, render_template, request, redirect, session
app = Flask(__name__)
app.secret_key = 'keep it secret, keep it safe'



@app.route('/') 
def user_input():
    return render_template('/index.html')


@app.route('/result', methods = ['POST'])
def result():
    session['Name'] = request.form['name']
    session['Star Wars'] = request.form['sw_choice']
    session['Favorite Language'] = request.form['fav_language']
    session['Comments'] = request.form['comment']
    print(request.form)
    return render_template('/results.html')



if __name__=="__main__": 
    app.run(debug=True) 