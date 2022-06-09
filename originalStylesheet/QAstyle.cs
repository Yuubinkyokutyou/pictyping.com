.Qa-Box {
  margin: 0 auto;
}

.Qa-Box .Qa dt,
.Qa-Box .Qa dd {
  display: flex;
  align-items: baseline;
  margin: 15px 0;
  padding: 15px;
}

.Qa-Box .Qa dt {
  background: #F5F5F5;
}

.Qa-Box .Qa dt p {
  margin: 0;
  padding-left: 15px;
  font-weight: bold;
  width: 100%;
}

.Qa-Box .Qa dd p {
  margin: 0;
  padding-left: 15px;
  width: 100%;
}

.Qa-Box .Qa dt::before {
  content: "Q";
  display: flex;
  justify-content: center;
  align-items: center;
  color: #fff;
  background: #66b3ff;
  width: 2em;
  height: 2em;
}

.Qa-Box .Qa dd::before {
  content: "A";
  display: flex;
  justify-content: center;
  align-items: center;
  color: #fff;
  background: #D65556;
  width: 2em;
  height: 2em;
}