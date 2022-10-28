from flask import Flask, render_template
app = Flask(__name__)


@app.route('/play')
def index():
    return render_template("index.html", color="blue", times=3 )

@app.route('/play/<int:times>')
def index(times):
    return render_template("index.html", color="blue", times=times )

@app.route('/<int:times>/<color>')
def index(color, times):
    return render_template("index.html", color=color, times=times )


if __name__=="__main__":  
    app.run(debug=True) 