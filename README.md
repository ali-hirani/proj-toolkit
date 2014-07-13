proj-toolkit
============

##Basic Git Bash Commands:

**git clone "repoURL"-**
initial import of entire cloud report into local folder

**git log**
//lists the commits made in that repository in reverse chronological order
//includes Author, Date and author's comment

**git log --oneline**

//Only author comments

**git pull**
pulls from cloud repo to local repo

**git reset --hard**

###How to push allchanges to cloud repo

1. **git add -A**
..* Add to index all files
Does the 2 below operations at once, 
..*	**git add .**
..* add to index only files created/modified and not those deleted
..* **git add -u**
..* add to index only files deleted/modified and not those created

2. **git commit -m "message"**
..* stamps a commit in the repo log

3. **git push**
..* pushes changes to cloud repo
