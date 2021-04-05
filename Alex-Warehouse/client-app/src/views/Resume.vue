<template>
  <q-page class="flex flex-center">
    <router-link to="/tasks" tag="button">Todo Page</router-link>
    <div class="main shadow-box" :class="'shadow-13'">
      <div class="left">

        <Heading/>
        <br/>

        <SkillStep/>
        <br/>

        <Timeline/>
        <br/>

        <Projects/>

      </div>

      <div class="right">
        <Logo/>
        <Contacts/>
        <Education/>
        <Triplebyte/>
      </div>
      <div class="flex-break q-py-md"></div>
    </div>

  </q-page>
</template>

<script>
import SkillStep from "@/components/resume/left/SkillStep";
import Timeline from "@/components/resume/left/Timeline";
import Projects from "@/components/resume/left/Projects";
import Heading from "@/components/resume/left/Heading";
import Logo from "@/components/resume/right/Logo";
import Contacts from "@/components/resume/right/Contacts";
import Education from "@/components/resume/right/Education";
import Triplebyte from "@/components/resume/right/Triplebyte";

export default {
  name: 'Resume',
  components: {
    Triplebyte,
    Education,
    Contacts,
    Timeline,
    SkillStep,
    Projects,
    Heading,
    Logo,
  },
}
</script>


<style>
.main {
  margin-left:15%;
  margin-right:15%;
  margin-top:6%;
  margin-bottom:6%;
  display: inline-flex;
  flex-direction: row;
  flex-wrap: nowrap;
  width: 100%;
  max-height: fit-content;
}
.left {
  background-color: #ffffff;
  width: 70%;
  height: inherit;
}

.right {
  background-color: #062b2b;
  width: 30%;
  height: inherit;
  color: whitesmoke;
}

</style>